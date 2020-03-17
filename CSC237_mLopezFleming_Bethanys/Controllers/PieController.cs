using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC237_mLopezFleming_Bethanys.Models;
using CSC237_mLopezFleming_Bethanys.ViewModels;
using Microsoft.AspNetCore.Mvc;

// Controllers are responsible to respond to user interaction
// Controllers directely interact with the model, updates the model
// Controller doesnt need to know about data persistance

namespace CSC237_mLopezFleming_Bethanys.Controllers
{
    public class PieController : Controller
    {
        // Access to repositories
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        // Constructor
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        // Action method
        public ViewResult List()
        {
            // Create new piesViewListModel object
            PiesListViewModel piesListViewModel = new PiesListViewModel();

            // Pass data for mock repository to pies
            piesListViewModel.Pies = _pieRepository.AllPies;

            // Set current category
            piesListViewModel.CurrentCategory = "Cheese cakes";

            // View to show
            return View(piesListViewModel);
        }
    }
}
