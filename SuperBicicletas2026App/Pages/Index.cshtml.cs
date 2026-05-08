using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperBicicletas2026App.Models;

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
            Bicicletas = new List<Bicicleta>
            {
                new Bicicleta { BikeId = 1, Nome = "Montain Bike Caloi", Descricao = "Para aventuras e trilhas", ImagemUri = "/imagens/bikeMontainCaloi.png", DataCadastro = DateTime.Now, EntregaExpressa = true, Preco = 6500.99 },

                new Bicicleta { BikeId = 2, Nome = "Montain Bike Oggi", Descricao = "Para trilhas e aventuras", ImagemUri = "/imagens/bikeMontainOggi.png", DataCadastro = DateTime.Now, EntregaExpressa = true, Preco = 5999.99 },

                new Bicicleta { BikeId = 3, Nome = "Bike Speed Specialized", Descricao = "Para competição e treinos na estradas", ImagemUri = "/imagens/bikeSpeedSP.png", DataCadastro = DateTime.Now, EntregaExpressa = true, Preco = 6999.99 },

                new Bicicleta { BikeId = 4, Nome = "Bike Speed Trek", Descricao = "Para estradas", ImagemUri = "/imagens/bikeSpeedTrek.png",DataCadastro = DateTime.Now, EntregaExpressa = true, Preco = 8500.99 }
            };
        }
    }
}
