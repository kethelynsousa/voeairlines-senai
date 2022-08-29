using VoeAirlinesSenai.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels;

namespace VoeAirlinesSenai.Services;

public class ManutencaoService{
    
    
    //propriedade para injeção de dependência
    private readonly VoeAirlinesContext _context;

    public ManutencaoService(VoeAirlinesContext context)
    {
        _context = context;
    }

    //public DetalhesManutencaoViewModel AdicionarManutencao(AdicionarManutencaoViewModel dados)
    //{
        
        /*
        var Manutencao = new Manutencao(dados.Fabricante, dados.Modelo, dados.Codigo,dados.Celebridade);

        _context.Add(Manutencao);
        _context.SaveChanges();

        return new DetalhesManutencaoViewModel
        (
            Manutencao.Id,
            Manutencao.Fabricante,
            Manutencao.Modelo,
            manuntecao.Codigo
        );
    }

    internal object ListarManutencaoPeloId(int id)
    {
        throw new NotImplementedException();
    }*/

    //public IEnumerable<ListarManuntecaoViewModel>ListarManutencao(){
        
    //    return _context.Manutencoes.Select(a=>new ListarManutencaoViewModel(a.Id,a.Modelo,a.Codigo));
    // }
    //public void ExcluirManutencao(int id){
    //    var aeronave = _context.Aeronaves.Find(id);
      //  if(aeronave != null){
            //_context.Remove(aeronave);
           //_context.SaveChanges();
      //  }
    //}
   /*
    public DetalhesManutencaoViewModel? AtualizarAeronave(AtualizarAeronaveViewModel dados){
              
              var aeronave = _context.Aeronaves.Find(dados.Id);
              if(aeronave != null){
                  aeronave.Fabricante = dados.Fabricante;
                  aeronave.Modelo = dados.Modelo;
                  aeronave.Codigo = dados.Codigo;
                  _context.Update(aeronave);
                  _context.SaveChanges();
                  return new DetalhesManutencaoViewModel(aeronave.Id,aeronave.Fabricante,aeronave.Modelo,aeronave.Codigo);

              }
              return null; 
     
    }*/
}
