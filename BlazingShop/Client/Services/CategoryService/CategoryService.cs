using BlazingShop.Shared;
using System.Net.Http.Json;

namespace BlazingShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadCategories()
        {
            //Categories = new List<Category>
            //{
            //    //new Category { Id = 1, Name ="Books", Url ="books", Icon="book"},
            //new Category { Id = 2, Name ="Electronics", Url ="electronics", Icon="camera-slr"},
            //new Category { Id = 3, Name ="Video Games", Url ="vedio-games", Icon="aperture"},
            //new Category { Id = 4, Name ="Movie", Url ="movie", Icon="video"}

            Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
            //}
        }
    }
}
