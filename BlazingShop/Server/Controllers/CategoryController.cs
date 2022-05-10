using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        //public List<Category> Categories { get; set; } = new List<Category>();

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            //return Ok(new List<Category>{
            //    new Category{Id=1, Name="Books", Url="books", Icon="book"},
            //    new Category{Id=2, Name="Electornis", Url="electornis", Icon="camera-slr"},
            //    new Category{Id=3, Name="Video Games", Url="video-games", Icon="aperture"},
            //    new Category { Id = 4, Name ="Movie", Url ="movie", Icon="video"}
            //});

            return Ok(await _categoryService.GetCategories());
        }
    }
}
