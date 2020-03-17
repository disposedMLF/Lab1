using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_mLopezFleming_Bethanys.Models
{
    // Domain class
    // POCO Class (Plain Old CLR Objects), a class that doesnt depend on any framework-specific bass class
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Discription { get; set; }

        // Each category will contain a list of pies
        public List<Pie> Pies { get; set; }
    }
}
