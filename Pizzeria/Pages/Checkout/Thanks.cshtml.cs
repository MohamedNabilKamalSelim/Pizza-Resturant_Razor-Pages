using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class ThanksModel : PageModel
    {
        public float TotalPrice { get; set; }
        public string PizzaName { get; set; }

        private readonly ApplicationDbContext _context;
        public ThanksModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            var order = new PizzaOrder();
            order.PizzaName = PizzaName;
            order.Price = TotalPrice;

            _context.PizzaOrders.Add(order);
            _context.SaveChanges();
        }
    }
}
