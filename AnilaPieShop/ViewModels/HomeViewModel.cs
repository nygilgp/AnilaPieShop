using System;
using System.Collections.Generic;
using AnilaPieShop.Models;

namespace AnilaPieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }

        public HomeViewModel()
        {
        }
    }
}
