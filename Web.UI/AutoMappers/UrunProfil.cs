using AutoMapper;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.UI.Models;

namespace Web.UI.AutoMappers
{
    public class UrunProfil:Profile
    {
        public UrunProfil()
        {
            CreateMap<Urun, UrunVM>();
            CreateMap<UrunVM, Urun>();
        }
    }
}
