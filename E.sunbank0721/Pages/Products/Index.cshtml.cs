using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E.sunbank0721.Data;
using E.sunbank0721.Models;

namespace E.sunbank0721.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly E.sunbank0721.Data.Esunbank0721Context _context;

        public IndexModel(E.sunbank0721.Data.Esunbank0721Context context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
