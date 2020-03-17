using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_mLopezFleming_Bethanys.Models
{
    // Domain class
    // POCO Class (Plain Old CLR Objects), a class that doesnt depend on any framework-specific bass class
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }

        // Each pie will be apart of a category, another class
        public Category Category { get; set; }
    }
}
