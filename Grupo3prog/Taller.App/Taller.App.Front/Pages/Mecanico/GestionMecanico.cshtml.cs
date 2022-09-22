using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Taller.App.Front.Pages
{
    public class GestionMecanicoModel : PageModel
    {
      public List<Mecanic>listaMecanicos=new List<Mecanic>(){

        new Mecanic() {nombre= "Freddy", especialidad = "electronico", ciudad = "Manizales"},
        new Mecanic() {nombre= "Sergio", especialidad = "llantas", ciudad = "Bogota"},
        new Mecanic() {nombre= "Carlos", especialidad = "vivir en las montañas", ciudad = "N"}
       

        };

        public void OnGet()
        {

      }

      public async Task<IActionResult> OnPostAsync(Mecanic m)
{
    if (!ModelState.IsValid)
    {
        return Page();
    }

    if (Customer != null) _context.Customer.Add(Customer);
    await _context.SaveChangesAsync();

    return RedirectToPage("./Index");
}

    }

    public class Mecanic {

        public string nombre {get; set;}
        public string especialidad {get; set;}
        public string ciudad {get; set;}

    }

}
