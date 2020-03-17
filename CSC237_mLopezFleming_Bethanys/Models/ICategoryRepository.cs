using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_mLopezFleming_Bethanys.Models
{
    // Interface is a declaration of one or more funtionalities
    // Entities that implement the interface MUST define the functionalities included
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
