using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication117.Models;
using WebApplication117.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory; // If Use Cach

namespace WebApplication117.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext context;
        public HomeController(AppDbContext cont)
        {
            context = cont;
        }
        
        public async Task<IActionResult> Index()
        {
            string value = "";
            if (Request.Cookies.Count != 0)
            {
                value = Request.Cookies[Hasher.clogin];
            }
            ViewBag.clogin = value;

            var prods = await context.products.ToListAsync();
            prods.RemoveAll(pr => pr.Hot != true);
            return View(prods);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
