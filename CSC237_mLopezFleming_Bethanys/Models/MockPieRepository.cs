using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_mLopezFleming_Bethanys.Models
{
    // The repository allows our code to use objects without knowing how they are persisted
    // Mock data 
    // Implement Pie Repository
    public class MockPieRepository : IPieRepository
    {
        // Hard-coded category repository instance to make it work
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name = "Strawberry Pie", Price = 15.95m, ShortDescription = "Lore ratssd", LongDescription = "Lore ratssd", AllergyInformation = "Lore ratssd", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", IsPieOfTheWeek = false, InStock = false, CategoryId = 1, Category = _categoryRepository.AllCategories.ToList()[0]},
                new Pie {PieId = 2, Name = "Cheese cake", Price = 18.95m, ShortDescription = "Lore ratssd", LongDescription = "Lore ratssd", AllergyInformation = "Lore ratssd", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", IsPieOfTheWeek = false, InStock = false, CategoryId = 2, Category = _categoryRepository.AllCategories.ToList()[1]},
                new Pie {PieId = 3, Name = "Rhubarb Pie", Price = 15.95m, ShortDescription = "Lore ratssd", LongDescription = "Lore ratssd", AllergyInformation = "Lore ratssd", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", IsPieOfTheWeek = false, InStock = false, CategoryId = 3, Category = _categoryRepository.AllCategories.ToList()[0]}, 
                new Pie {PieId = 4, Name = "Pumpkin Pie", Price = 12.95m, ShortDescription = "Lore ratssd", LongDescription = "Lore ratssd", AllergyInformation = "Lore ratssd", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", IsPieOfTheWeek = false, InStock = false, CategoryId = 4, Category = _categoryRepository.AllCategories.ToList()[2]}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
