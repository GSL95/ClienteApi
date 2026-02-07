namespace ClienteApi.DTOs
{
    public class ClienteReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public InteresseCliente Interesse { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
