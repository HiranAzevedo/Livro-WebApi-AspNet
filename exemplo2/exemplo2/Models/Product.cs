using System.ComponentModel.DataAnnotations;

namespace exemplo2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatorio")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required, StringLength(8, ErrorMessage = "O tamanho	máximo	do	código	é	8	caracteres")]
        public string Codigo { get; set; }

        [Range(10, 999, ErrorMessage = "O	preço	deverá	ser	entre	10	e	999.")]
        public decimal Preco { get; set; }

        [MaxLength(80)]
        public string Url { get; set; }
    }
}