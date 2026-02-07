using ClienteApi.Data;
using ClienteApi.DTOs;
using ClienteApi.Model;
using ClienteApi.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace ClienteApi.Service
{
    public class ClienteService : IClienteService
    {
        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ClienteReadDto> CriarAsync(ClienteCreateDto dto)
        {
            if (await _context.Clientes.AnyAsync(c => c.Email == dto.Email))
                {
                throw new Exception("Email já cadastrado");
                }
            var cliente = new Cliente()
            {
                Name = dto.Name,
                Email = dto.Email,
                Phone = dto.Phone,
                Interesse = dto.Interesse,
                Date = DateTime.UtcNow
            };
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return MapToReadDto(cliente);

        }

        public async Task<IEnumerable<ClienteReadDto>> ListarAsync()
        {
            return await _context.Clientes.Select(c => MapToReadDto(c)).ToListAsync();
        }

        public async Task<ClienteReadDto> BuscarPorIdAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            return cliente == null ? null : MapToReadDto(cliente);
        }

        public async Task<bool> AtualizarAsync(ClienteUpdateDto dto)
        {
            var cliente = await _context.Clientes.FindAsync(dto.Id);
            if (cliente == null) return false;

            cliente.Name = dto.Name;
            cliente.Email = dto.Email;
            cliente.Phone = dto.Phone;
            cliente.Interesse = dto.Interesse;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoverAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null) return false;
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ClienteReadDto>> ListarPorInteresseAsync(InteresseCliente interesse)
        {
            var clientes = await _context.Clientes.Where(c => c.Interesse == interesse).ToListAsync();

            return clientes.Select(c => MapToReadDto(c));
        }



        public static ClienteReadDto MapToReadDto(Cliente cliente)
        {
            return new ClienteReadDto
            {
                Id = cliente.Id,
                Name = cliente.Name,
                Email = cliente.Email,
                Phone = cliente.Phone,
                Interesse = cliente.Interesse,
                DataCadastro = cliente.Date
            };
        }
    }
    

    
}
