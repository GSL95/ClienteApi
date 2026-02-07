using ClienteApi.DTOs;
using ClienteApi.Service;
using ClienteApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClienteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        public readonly IClienteService _clienteService;
        public ClienteController(IClienteService service)
        {
            _clienteService = service;
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] ClienteCreateDto dto)
        {
            var cliente = await _clienteService.CriarAsync(dto);
            return CreatedAtAction(nameof(ObterPorId), new { id = cliente.Id }, cliente);
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var clientes = await _clienteService.ListarAsync();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var cliente = await _clienteService.BuscarPorIdAsync(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        [HttpGet("por-interesse")]
        public async Task<IActionResult> ListarPorInteresse([FromQuery] InteresseCliente interesse)
        {
            var clientes = await _clienteService.ListarPorInteresseAsync(interesse);
            return Ok(clientes);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] ClienteUpdateDto dto)
        {
            if (id != dto.Id)
                return BadRequest("Id da rota diferente do corpo");

            var atualizado = await _clienteService.AtualizarAsync(dto);

            if (!atualizado)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(int id)
        {
            var removido = await _clienteService.RemoverAsync(id);

            if (!removido)
                return NotFound();

            return NoContent();
        }


    }
}
