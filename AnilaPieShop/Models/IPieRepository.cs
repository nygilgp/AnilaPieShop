using System;
using System.Collections.Generic;
namespace AnilaPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
