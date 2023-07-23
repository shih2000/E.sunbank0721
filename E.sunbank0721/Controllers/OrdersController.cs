using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

using E.sunbank0721.Data;
using E.sunbank0721.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;



namespace E.sunbank0721.Controllers
{
    public class OrdersController : Controller
    {
        private readonly E.sunbank0721.Data.Esunbank0721Context _context;

        public OrdersController(E.sunbank0721.Data.Esunbank0721Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string searchString)
        {


            var orders = from m in _context.Order
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(s => s.OrderID.Contains(searchString));
            }
            return View(await orders.ToListAsync());
        }
    }
}
