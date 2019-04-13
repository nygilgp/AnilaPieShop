using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnilaPieShop.Models;
using AnilaPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnilaPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRpository)// dependency injuction
        {
            _pieRepository = pieRpository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies().OrderBy((Pie arg) => arg.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Anila's Pie Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}
