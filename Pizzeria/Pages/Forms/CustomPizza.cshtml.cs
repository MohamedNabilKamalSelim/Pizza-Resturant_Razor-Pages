using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaViewModel Pizza { get; set; }

        public float TotalPrice { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost(IFormFile imageFile)
        {
            TotalPrice += Pizza.BasePrice;

            if (Pizza.Beef) TotalPrice++;
            if (Pizza.Peperoni) TotalPrice++;
            if (Pizza.TomatoSauce) TotalPrice++;
            if (Pizza.Mushroom) TotalPrice++;
            if (Pizza.Cheese) TotalPrice++;
            if (Pizza.Ham) TotalPrice++;
            if (Pizza.Pineaple) TotalPrice += 10;


            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, TotalPrice });
        }
    }
}
