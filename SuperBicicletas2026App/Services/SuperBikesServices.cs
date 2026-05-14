using SuperBicicletas2026App.Models;

namespace SuperBicicletas2026App.Services;

public class SuperBikesServices
{
    private IList<Bicicleta> _Bicicletas;

    public SuperBikesServices()
    {
        CarregarListaInicial();
    }
    public IList<Bicicleta> ObterTodos()
    {
        return _Bicicletas;
    }
    public Bicicleta Obter(int id)
    {
        return _Bicicletas.Single(item => item.BikeId == id);
    }
    private void CarregarListaInicial()
    {
        _Bicicletas = new List<Bicicleta>()
            {
                new Bicicleta { BikeId = 1, Nome = "Montain Bike Caloi", Descricao = "Para aventuras e trilhas", ImagemUri = "/imagens/bikeMontainCaloi.png", DataCadastro = DateTime.Now, EntregaExpressa = true, Preco = 6500.99 },

                new Bicicleta { BikeId = 2, Nome = "Montain Bike Oggi", Descricao = "Para trilhas e aventuras", ImagemUri = "/imagens/bikeMontainOggi.png", DataCadastro = DateTime.Now, EntregaExpressa = true, Preco = 5999.99 },

                new Bicicleta { BikeId = 3, Nome = "Bike Speed Specialized", Descricao = "Para competição e treinos na estradas", ImagemUri = "/imagens/bikeSpeedSP.png", DataCadastro = DateTime.Now, EntregaExpressa = true, Preco = 6999.99 },

                new Bicicleta { BikeId = 4, Nome = "Bike Speed Trek", Descricao = "Para estradas", ImagemUri = "/imagens/bikeSpeedTrek.png",DataCadastro = DateTime.Now, EntregaExpressa = true, Preco = 8500.99 }
            };
    }
}
