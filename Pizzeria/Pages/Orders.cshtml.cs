using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<PizzaOrder> orders = new List<PizzaOrder>();
        public void OnGet()
        {
            orders = _context.PizzaOrders.ToList();
        }
    }
}
