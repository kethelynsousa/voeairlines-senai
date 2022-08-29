
using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels;


public class AdicionarManutencaoViewModel
{
    public AdicionarManutencaoViewModel(string fabricante, string modelo, TipoManuntecao manuntecao, string codigo, string celebridade)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Manuntecao = manuntecao;
        Codigo = codigo;
        Celebridade = celebridade;
    }

    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public TipoManuntecao Manuntecao{ get; set;}
    public string Codigo { get; set; }
    public string Celebridade { get; set; }

}