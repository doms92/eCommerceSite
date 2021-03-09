using eCommerceSite.Data;
using eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Controllers
{
    public class CartController1 : Controller
    {
        private readonly ProductContext _context;
        public CartController1(ProductContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds a product to the shopping cart
        /// </summary>
        /// <param name="id">The id of the product </param>
        /// <returns></returns>
        public async Task<IActionResult> Add(int id) 
        {
            // Get product from the database
            Product p = await (from products in _context.Products
                         where products.ProductId == id
                         select products).SingleAsync();
            // Add product to cart cookie

            // Redirect back to previous page
            return View();
        }

        public IActionResult Summary()
        {
            // Display all products in shopping cart cookie
            return View();
        }
    }
}
