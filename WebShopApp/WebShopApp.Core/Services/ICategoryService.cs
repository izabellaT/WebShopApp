﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShopApp.Infrastructure.Data.Domain;

namespace WebShopApp.Core.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategoryById(int categoryId);
        List<Product> GetProductByCategory(int categoryId);
    }
}
