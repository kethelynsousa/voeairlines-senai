using VoeAirlinesSenai.Contexts;
using VoeAirlinesSenai.Entities;
using VoeAirlinesSenai.ViewModels;

namespace VoeAirlinesSenai.Services;

public class AeronaveService{
    
    
    //propriedade para injeção de dependência
    private readonly VoeAirlinesContext _context;

    public AeronaveService(VoeAirlinesContext context)
    {
        _context = context;
    }

    public DetalhesAeronaveViewModel AdicionarAeronave(AdicionarAeronaveViewModel dados)
    {
        

        var aeronave = new Aeronave(dados.Fabricante, dados.Modelo, dados.Codigo);

        _context.Add(aeronave);
        _context.SaveChanges();

        return new DetalhesAeronaveViewModel
        (
            aeronave.Id,
            aeronave.Fabricante,
            aeronave.Modelo,
            aeronave.Codigo
        );
    } 
     public IEnumerable<ListarAeronaveViewModel>ListarAeronave(){
        
         return _context.Aeronaves.Select(a=>new ListarAeronaveViewModel(a.Id,a.Modelo,a.Codigo));
     }
   public DetalhesAeronaveViewModel listarAeronavePeloId(int id ){

    var aeronave= _context.Aeronaves.Find(id);
    if(aeronave !=null){
        return new DetalhesAeronaveViewModel(
        aeronave.Id,
        aeronave.Fabricante,
        aeronave.Modelo,
        aeronave.Codigo);
    }
    return null;
   }
   public DataMisalignedException AtualizarAeronave(AtualizarAeronaveViewModel dados){

    return null ;

   }
    
public void Excluir(int id){
    var aeronave= _context.Aeronaves.Find(id);
    if(aeronave !=null)
{ _context.Remove(aeronave);
  _context.SaveChanges();
}

}

}



