using BlazingShop.Server.Data;
using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
           _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.Include(p=>p.Variants).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            //Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            Product product = await _context.Products
                .Include(p=>p.Variants)
                .ThenInclude(v=>v.Edition)
                .FirstOrDefaultAsync(p=>p.Id==id);

            product.Views++;

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Include(p=> p.Variants).Where(p=>p.CategoryId==category.Id).ToListAsync();
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _context.Products
                .Where(p=>p.Title.Contains(searchText)||p.Description.Contains(searchText))
                .ToListAsync();
        }

        //public List<Product> Products { get; set; } = new List<Product>
        //{
        //        new Product
        //            {
        //                Id = 1,
        //                CategoryId = 1,
        //                Title = "라푼젤",
        //                Description = "독일 지방의 설화로, 이를 그림 형제가 채집해 동화로 각색해서 1812년의 동화집에 수록했다.",
        //                Image = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Rapunzel-Paul-Hey.jpg",
        //                Price = 9.99m,
        //                OriginalPrice = 19.99m
        //            },
        //           new Product
        //            {
        //                Id = 11,
        //                CategoryId = 1,
        //                Title = "라푼젤 2탄",
        //                Description = "라푼젤 1탄의 후속작으로 1탄에 이어 엄청난 호평을 받았다.",
        //                Image = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Rapunzel-Paul-Hey.jpg",
        //                Price = 25.99m,
        //                OriginalPrice = 29.99m
        //            },
        //            new Product
        //            {
        //                Id = 2,
        //                CategoryId = 2,
        //                Title = "아이폰5",
        //                Description = "iPhone 이래 가장 획기적인 iPhone",
        //                Image = "https://upload.wikimedia.org/wikipedia/commons/f/fa/IPhone_5.png",
        //                Price = 68.19m,
        //                OriginalPrice = 199.99m
        //            },
        //             new Product
        //            {
        //                Id = 3,
        //                CategoryId = 3,
        //                Title = "슈퍼마리오",
        //                Description = "닌텐도의 대표 비디오 게임인 마리오 시리즈의 핵심이 되는 본가 시리즈.",
        //                Image = "https://upload.wikimedia.org/wikipedia/commons/6/67/Dibujo_de_Mario.jpg",
        //                Price = 14.24m,
        //                OriginalPrice = 53.91m
        //            },
        //             new Product
        //            {
        //                Id = 4,
        //                CategoryId = 4,
        //                Title = "블랙핑크 콘서트",
        //                Description = "2019년 암스테르담에서 열린 콘서트",
        //                Image = "https://upload.wikimedia.org/wikipedia/commons/1/1d/20190518_Blackpink_Amsterdam_concert_18.jpg",
        //                Price = 14.24m,
        //                OriginalPrice = 53.91m,
        //                Href ="https://www.youtube.com/watch?v=nJiVgPncupo"
        //            }                 
        //    };




    }
}

