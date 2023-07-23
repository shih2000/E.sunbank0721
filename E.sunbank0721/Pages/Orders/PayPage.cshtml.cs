using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E.sunbank0721.Data;
using E.sunbank0721.Models;
using Microsoft.EntityFrameworkCore;


namespace E.sunbank0721.Pages.Orders
{
    public class PayPageModel : PageModel
    {
        private readonly E.sunbank0721.Data.Esunbank0721Context _context;
        public PayPageModel(E.sunbank0721.Data.Esunbank0721Context context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
             return Page();
        }

        [BindProperty]
        public Order Order{ get; set; } = default!;
    }
}
