﻿using BlazingShop.Shared;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category> {
             new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "vedio-games", Icon = "aperture" },
                new Category { Id = 4, Name = "Movie", Url = "movie", Icon = "video" }
        };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
