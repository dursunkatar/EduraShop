using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Models
{
    public class HomeVM
    {
        public IEnumerable<UrunVM> Urunler { get; set; }
    }
}
