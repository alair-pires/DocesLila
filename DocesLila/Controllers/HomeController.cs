using DocesLila.Context;
using DocesLila.Entities;
using DocesLila.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DocesLila.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DocesLilaContext _dbContext;

        public HomeController(ILogger<HomeController> logger, DocesLilaContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index(int page = 1, int pageSize = 6)
        {
            int totalProducts = _dbContext.Products.Count();
            int totalPages = (int)Math.Ceiling((double)totalProducts / pageSize);

            if (page < 1)
            {
                page = 1;
            }
            else if (page > totalPages)
            {
                page = totalPages;
            }

            var productsToDisplay = _dbContext.Products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            //var products = _dbContext.Products.ToList();
            ViewData["TotalPages"] = totalPages;
            ViewData["CurrentPage"] = page;

            return View(productsToDisplay);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var productDetail = await _dbContext.Products.FindAsync(id);
            if (productDetail == null)
            {
                return NotFound();
            }
            return View(productDetail);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Title, Batch, Description, Price, Quantity, RegistrationDate, ExpireDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    product.RegistrationDate = DateTime.Now.Date;
                    _dbContext.Add(product);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    if (!Exists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            return View(product);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _dbContext.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Update(product);
                    await _dbContext.SaveChangesAsync();
                }
                catch (Exception)
                {
                    if (!Exists(id))
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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

        private bool Exists(int id)
        {
            return _dbContext.Products.Any(x => x.Id == id);
        }
    }
}
