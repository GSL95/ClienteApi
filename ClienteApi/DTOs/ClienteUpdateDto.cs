using System.ComponentModel.DataAnnotations;

namespace ClienteApi.DTOs
{
    public class ClienteUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [Phone]
        public string Phone { get; set; } = null!;

        [Required]
        public InteresseCliente Interesse {  get; set; }
    }
}
