using DocesLila.Context;
using DocesLila.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocesLila.Models
{
    public class ProductModel : PageModel
    {
        private readonly DocesLilaContext _context;

        public ProductModel(DocesLilaContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}
