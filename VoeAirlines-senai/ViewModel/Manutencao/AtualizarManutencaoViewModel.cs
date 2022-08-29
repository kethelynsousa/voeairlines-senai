namespace VoeAirlines.ViewModels;
public class AtualizarManutencaoViewModel
{
    public AtualizarManutencaoViewModel(int id, string fabricante, TipoManuntecao manuntecao, string modelo, string codigo)
    {
        Id = id;
        Fabricante = fabricante;
        Manuntecao = manuntecao;
        Modelo = modelo;
        Codigo = codigo;
    }

    public int Id { get; set; }
    public string Fabricante { get; set; }
   public TipoManuntecao Manuntecao{ get; set;}
    public string Modelo { get; set; }
    public string Codigo { get; set; }
}