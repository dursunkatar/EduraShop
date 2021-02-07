using AutoMapper;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUrunService _urunService;
        private readonly IMapper _mapper;

        public HomeController(IUrunService urunService, IMapper mapper)
        {
            _urunService = urunService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var _urunler = await _urunService.GetAllAsync();
            var model = new HomeVM
            {
                Urunler = _urunler.Select(m => _mapper.Map<UrunVM>(m)).ToList()
            };
            return View(model);
        }

        public IActionResult Detail()
        {
            return View();
        }


    }
}
