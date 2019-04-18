using System;
namespace AnilaPieShop.Models
{
    public class Pie
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public string ImageUrl { get; internal set; }
        public string ImageThumbnailUrl { get; internal set; }
        public bool IsInStock { get; set;  }

        public Pie()
        {
        }
    }
}
