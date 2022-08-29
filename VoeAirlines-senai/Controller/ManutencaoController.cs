/*using VoeAirlinesSenai.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels;
using Microsoft.AspNetCore.Mvc;
using VoeAirlinesSenai.Services;
 
 namespace VoeAirlines.Services;
[Route("api/Manutencao")]
[ApiController]
public class ManutencaoController : ControllerBase{

{
    private readonly ManutencaoService _ManutencaoService;

    public ManutencaoController(ManutencaoService ManutencaoService)
    {
        _ManutencaoService = ManutencaoService;
    }

    [HttpGet]
    public IActionResult ListarManutencao(){
        var Manutencao = _ManutencaoService.ListarManutencao();
        return Ok(Manutencao);
    }
     [HttpGet("{id}")]
    public IActionResult ListarManutencaoPeloId(int id){
        
        var Manutencao = _ManutencaoService.ListarManutencaoPeloId(id);
        if(Manutencao!=null){
            return Ok(Manutencao);
        }
        return NotFound();
    }
    [HttpPut("{id}")]
    public IActionResult AtualizarManutencao(int id,AtualizarManutencaoViewModel dados){
        if(id != dados.Id){
            return BadRequest("O id informado na URL é diferente do id informado no corpo da requisição");
        }
        var Manuntecao = _ManutencaoService.AtualizarManutencao(dados);
        return Ok(Manuntecao);
    }

    [HttpDelete("{id}")]
    public IActionResult ExcluirManutencao(int id){
        _ManutencaoService.ExcluirManutencao(id);
        return NoContent();
    }
}

}

*/