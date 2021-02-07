using AutoMapper;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.UI.Models;

namespace Web.UI.ViewComponents
{
    public class KategorilerViewComponent : ViewComponent
    {
        private readonly IKategoriService _kategoriService;
        public KategorilerViewComponent(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        public ViewViewComponentResult Invoke()
        {
            var kategoriler = _kategoriService.KategorilerWithUrunAdet().Select(m => new KategoriVM
            {
                KategoriId = m.KategoriId,
                KategoriAdi = m.KategoriAdi,
                UrunAdet = m.Urunler.Count
            }).ToList();
            return View(kategoriler);
        }
    }
}
