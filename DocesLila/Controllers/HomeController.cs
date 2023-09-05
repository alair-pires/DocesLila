using DocesLila.Context;
using DocesLila.Entities;
using DocesLila.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DocesLila.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DocesLilaContext _dbContext;
        private readonly IWebHostEnvironment _environment;

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
        public async Task<IActionResult> Create(ProductsViewModel productVW)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Verifique se o diretório de destino existe; se não, crie-o
                    //if (productVW.FileUpload.Arquivo != null)
                    //{
                    //    string uploadDir = Path.Combine(_environment.WebRootPath, "Images");
                    //    if (!Directory.Exists(uploadDir))
                    //    {
                    //        Directory.CreateDirectory(uploadDir);
                    //    }
                    //    // Gere um nome de arquivo único para evitar conflitos
                    //    string fileName = Path.GetFileName(productVW.FileUpload.Arquivo.FileName);
                    //    string filePath = Path.Combine(uploadDir, fileName);

                    //    using (var stream = new FileStream(filePath, FileMode.Create))
                    //    {
                    //        productVW.FileUpload.Arquivo.CopyTo(stream);
                    //    }

                    //    ViewBag.Message = "Arquivo enviado com sucesso!";
                    //}

                    var product = new Product
                    {
                        Title = productVW.Product.Title,
                        Description = productVW.Product.Description,
                        Batch = productVW.Product.Batch,
                        Price = productVW.Product.Price,
                        Quantity = productVW.Product.Quantity,
                        ExpireDate = productVW.Product.ExpireDate,
                        RegistrationDate = DateTime.Now.Date
                    };
                    //product.RegistrationDate = DateTime.Now.Date;
                    _dbContext.Add(product);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    if (!Exists(productVW.Product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            }
            return View(productVW);
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
