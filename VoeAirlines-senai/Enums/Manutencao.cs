namespace VoeAirlinesSenai.Entities;
using VoeAirlinesSenai.Entities.Enums;
public class  Manutencao{
    public Manutencao(DateTime dataHora, TipoManutencao tipo, int aeronaveId,string? observacoes=null)
    {
        DataHora = dataHora;
        this.observacoes = observacoes;
        this.tipo = tipo;
        AeronaveId = aeronaveId;
       
    }


    public int Id {get;set;}
    public DateTime DataHora {get;set;}
    public string? observacoes {get;set;}
    public TipoManutencao tipo { get;set;}
    public int AeronaveId {get;set;}
    public Aeronave Aeronave { get;set;}=null!;

}