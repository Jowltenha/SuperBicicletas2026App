using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperBicicletas2026App.Models;
using SuperBicicletas2026App.Services;

namespace SuperBicicletas2026App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IList<Bicicleta> Bicicletas { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var service = new SuperBikesServices();
            Bicicletas = service.ObterTodos();
        }
    }
}
