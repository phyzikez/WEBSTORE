using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication117.Models;

namespace WebApplication117.Controllers
{

    public class ProductDBController : Controller
    {
        public AppDbContext context; 
        public ProductDBController(AppDbContext cont)
        {
            context = cont;
        }

        public async Task<IActionResult> Products()
        {
            return View(await context.products.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
 
            var product = await context.products.FirstOrDefaultAsync(pr => pr.Id == id);
            if (product == null)
            {
                return NotFound(); 
            }

            var photos = await context.photos.ToListAsync();
            photos.RemoveAll(ph => ph.IdProd != id);

            var calls = await context.callbacks.ToListAsync();
            calls.RemoveAll(ph => ph.IdProduct != id);

            ProductInfo productInfo = new ProductInfo();
            productInfo.Photos = photos;
            productInfo.Prod = product;
            productInfo.Callbacks = calls;

            return View(productInfo);
        }
    }
}