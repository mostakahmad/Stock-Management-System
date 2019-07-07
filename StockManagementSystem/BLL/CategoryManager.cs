using StockManagementSystem.Models;
using StockManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public DataTable LoadCategories()
        {
            return _categoryRepository.LoadCategories();
        }

        public int InsertCategory(Category category)
        {
            return _categoryRepository.InsertCategory(category);
        }

        public int CheckCategory(Category category)
        {
            return _categoryRepository.CheckCategory(category);
        }
    }
}
