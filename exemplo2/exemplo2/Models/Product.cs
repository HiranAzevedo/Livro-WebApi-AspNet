using System.ComponentModel.DataAnnotations;

namespace exemplo2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required]
        public string Codigo { get; set; }

        public decimal Preco { get; set; }
    }
}