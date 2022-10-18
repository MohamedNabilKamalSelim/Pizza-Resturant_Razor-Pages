using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzaViewModel> fakePizzaDB = new List<PizzaViewModel>()
        {
           new PizzaViewModel() { ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 4 },
           new PizzaViewModel() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 6 },
           new PizzaViewModel() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true,  Mushroom = true, FinalPrice = 6 },
           new PizzaViewModel() { ImageTitle = "MeatFeast", PizzaName = "Meat Feast", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 6 },
           new PizzaViewModel() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Peperoni = true, FinalPrice = 6 },
           new PizzaViewModel() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, TomatoSauce = true, Cheese = true,  Mushroom = true, FinalPrice = 5 },
           new PizzaViewModel() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 2, TomatoSauce = true, Cheese = true, Peperoni = true, FinalPrice = 5 },
           new PizzaViewModel() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 5 },
           new PizzaViewModel() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 2, TomatoSauce = true, Cheese = true,  Mushroom = true, Peperoni = true, FinalPrice = 6 }
        };
        public void OnGet()
        {
        }
    }
}
