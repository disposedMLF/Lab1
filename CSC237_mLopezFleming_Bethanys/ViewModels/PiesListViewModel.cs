using CSC237_mLopezFleming_Bethanys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_mLopezFleming_Bethanys.ViewModels
{
    // View model is a class that wraps multiple properties so the view can access all the data it needs
    public class PiesListViewModel
    {
        // Property for each data needed in the view
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
