using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_mLopezFleming_Bethanys.Models
{
    // The repository allows our code to use objects without knowing how they are persisted
    // Mock data 
    // Implement Category Repository
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Fruit pies", Discription = "All-fruity pies"},
                new Category{CategoryId = 2, CategoryName = "Cheese cakes", Discription = "Cheesy all the way"},
                new Category{CategoryId = 3, CategoryName = "Seasonal pies", Discription = "Get in the mood for a seasonal pie"}
            };
    }
}
