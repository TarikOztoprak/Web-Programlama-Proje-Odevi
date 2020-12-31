using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Web_Proje.Models;

namespace Web_Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.books.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Books()
        {
          
            return View(await _context.books.ToListAsync());
        }

        public async Task<IActionResult> Book(int id)
        {
            ViewBag.id = id;
            return View(await _context.books.ToListAsync());
        }

        public async Task<IActionResult> Message(int id)
        {
            ViewBag.id = id;
            return View(await _context.messages.ToListAsync());
        }

        public IActionResult MessageCreate(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
