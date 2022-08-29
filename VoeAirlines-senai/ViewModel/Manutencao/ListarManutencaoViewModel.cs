
namespace VoeAirlines.ViewModels;
public class ListarManutencaoViewModel
{
    public ListarManutencaoViewModel(int id, string modelo, TipoManuntecao manuntecao, string codigo)
    {
        Id = id;
        Modelo = modelo;
        Manuntecao = manuntecao;
        Codigo = codigo;
    }

    public int Id { get; set; }
    public string Modelo { get; set; }
    public TipoManuntecao Manuntecao{ get; set;}
    public string Codigo { get; set; }
}