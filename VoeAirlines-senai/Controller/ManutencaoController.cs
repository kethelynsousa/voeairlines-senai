using VoeAirlinesSenai.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels.Manutencao;
using Microsoft.AspNetCore.Mvc;
using VoeAirlinesSenai.Services;

namespace VoeAirlines.Controller;

   [Route("api/manutencao")]
    [ApiController]
    public class ManutencaoController : ControllerBase
    {
        private readonly ManutencaoService _manutencaoService;

        public ManutencaoController(ManutencaoService manutencaoService)
        {
            _manutencaoService = manutencaoService;
        }

        [HttpGet]
        public IActionResult ListarManutencao()
        {
            var manutencao = _manutencaoService.ListarManutencoes();
            return Ok(manutencao);
        }

        [HttpGet("{id:int}")]
        public IActionResult ListarPorId(int id)
        {
            var manutencao = _manutencaoService.ListarManutencaoPorId(id);
            return Ok (manutencao);
        }



    [HttpGet("porAeronave/{aeronaveId}")]
        public IActionResult ListarPorAeronave(int aeronaveId)
        {
            var manutencoes = _manutencaoService.ListarManutencoesPorAeronave(aeronaveId);
            return Ok(manutencoes);
        }

        [HttpPost]
        public IActionResult AdicionarManutencao(AdicionarManutencaoViewModel dados) 
        {
            var manutencao = _manutencaoService.AdicionarManutencao(dados);
            return Created(nameof(AdicionarManutencao), manutencao);
        }

        [HttpPut("{id:int}")]
        public IActionResult AtualizarManutencao(int id, AtualizarManutencaoViewModel dados) 
        {
            var manutencao = _manutencaoService.AtualizarManutencao(id, dados);
            return Ok(manutencao);
        }

        [HttpDelete("{id:int}")]
        public IActionResult RemoverManutencao(int id)
        {
            var manutencao = _manutencaoService.RemoverManutencao(id);
            return Ok(manutencao);
        }


    }
