using ClienteApi.DTOs;

namespace ClienteApi.Service.Interface
{
    public interface IClienteService
    {
        Task<ClienteReadDto> CriarAsync(ClienteCreateDto dto);
        Task<IEnumerable<ClienteReadDto>> ListarAsync();
        Task<ClienteReadDto?> BuscarPorIdAsync(int id);
        Task<bool> AtualizarAsync(ClienteUpdateDto dto);
        Task<bool> RemoverAsync(int id);
        Task<IEnumerable<ClienteReadDto>> ListarPorInteresseAsync(InteresseCliente interesse);

    }
}
