using Microsoft.AspNetCore.Mvc;
using MVC_ShoppingCart.Models;

namespace MVC_ShoppingCart.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayItems() 
        {
            List<ItemModel> items = new List<ItemModel>
            {
                new ItemModel { Name = "Laptop", Quantity = 11, Price = 1500.00 },
                new ItemModel { Name = "Desktop", Quantity = 13, Price = 1200.00 },
                new ItemModel { Name = "Monitor", Quantity = 25, Price = 400.00 },
                new ItemModel { Name = "Keyboard", Quantity = 15, Price = 100.00 },
                new ItemModel { Name = "Mouse", Quantity = 30, Price = 50.00 },

            };

            return View(items); 
        }
    }
}
