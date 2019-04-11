using System;
using System.Collections.Generic;
using System.Linq;

namespace AnilaPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if(_pies == null)
            {
                initializePie();
            }
        }

        public void initializePie()
        {
            _pies = new List<Pie>
            {
                new Pie {Id = 1, Name = "Apple Pie", ShortDescription = "Short", Price = 10.9M },
                new Pie {Id = 2, Name = "Blue Berry Pie", ShortDescription = "Short", Price = 12.9M },
                new Pie {Id = 3, Name = "Strawberry Pie", ShortDescription = "Short", Price = 11.9M },
                new Pie {Id = 4, Name = "Banana Pie", ShortDescription = "Short", Price = 15.9M },

            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
