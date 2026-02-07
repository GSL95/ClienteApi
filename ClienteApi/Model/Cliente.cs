namespace ClienteApi.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public InteresseCliente Interesse { get; set; }

    }
}
