using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimePolitico.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimePolitico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliticoController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            return Ok("Listagem de todos os Candidatos");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, Politico candidato)
        {
            return Ok("Dados atualizados do Candidato:<br> Nome do Candidato:" + candidato.nomeCandidato + " Partido: " + candidato.partido + "Numero do Candidato: " + candidato.numero + "Cargo: " + candidato.cargo);
        }

  

        [HttpPost]
        public async Task<IActionResult> Post(Politico candidato)
        {
            if (string.IsNullOrEmpty(candidato.nomeCandidato)) {
                return BadRequest("Nome do Politico está vazio, tente novamente!");
            }
            return Ok("Politico Cadastrado com sucesso");
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, Politico candidato)
        {

            if (string.IsNullOrEmpty(candidato.nomeCandidato))
            {
                return BadRequest("Verifique novamente os dados do Paciente!");
            }
            return Ok("Dados atualizados do Candidato:<br> Nome do Candidato:" + candidato.nomeCandidato + " Partido: " + candidato.partido + "Numero do Candidato: " + candidato.numero + "Cargo: " + candidato.cargo);

        }
            [HttpDelete]
            public async Task<IActionResult> Delete(int id)
            {
                if (id > 0)
                {
                    return Ok("Candidato deletado com sucesso!");
                }
                return BadRequest("HAHA, o que já foi cadastrado nunca será deletado");
            }
        
    }
}
