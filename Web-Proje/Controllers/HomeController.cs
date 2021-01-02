﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Web_Proje.Models;

namespace Web_Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ILogger<HomeController> logger, Context context, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _context = context;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["sonEklenenKitaplar"] = _localizer["Son Eklenen Kitaplar"];
            ViewData["kitaplarınDünyası"] = _localizer["KİTAPLARIN DÜNYASI"];
            ViewData["edebiyatKitapları"] = _localizer["Edebiyat Kitapları"];
            ViewData["çocukKitapları"] = _localizer["Çocuk ve Gençlik Kitapları"];
            ViewData["eğitimKitapları"] = _localizer["Eğitim Kitapları"];
            ViewData["tümünüGörüntüle"] = _localizer["Tümünü Görüntüle"];
            return View(await _context.books.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Books()
        {
            ViewData["tümKitaplar"] = _localizer["Tüm Kitaplar"];
            return View(await _context.books.ToListAsync());
        }

        public async Task<IActionResult> Book(int id)
        {
            ViewData["ilkBasımTarihi"] = _localizer["İlk Basım Tarihi"];
            ViewData["sayfaSayısı"] = _localizer["Sayfa Sayısı"];
            ViewData["yorumlar"] = _localizer["Yorumlar"];
            ViewBag.id = id;
            return View(await _context.books.ToListAsync());
        }

     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
