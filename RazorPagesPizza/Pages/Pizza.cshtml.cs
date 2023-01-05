using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace RazorPagesPizza.Pages
{
    public class PizzaModel : PageModel
    {
        [BindProperty]
public Pizza NewPizza { get; set; } = new();
    public List<Pizza> pizzas = new();

        public void OnGet()
        {
           pizzas = PizzaService.GetAll();  
        }

        public IActionResult OnPost()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }
    PizzaService.Add(NewPizza);
    return RedirectToAction("Get");
}
        public string GlutenFreeText(Pizza pizza)
           {
              if(pizza.IsGlutenFree)
              return "Gluten Free";
              return "Not Gluten Free";
           }
    }
}
