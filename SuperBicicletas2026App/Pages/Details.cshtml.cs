using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperBicicletas2026App.Models;

namespace SuperBicicletas2026App.Pages
{
    public class DetailsModel : PageModel
    {
        public Bicicleta Bicicleta { get; set; }
        public void OnGet()
        {
        }
    }
}
