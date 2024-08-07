using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIxUnit.Domains
{
    public class ProductsDomain
    {
        [Key]
        public Guid IdProduct { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        public string? Name { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "O Preço do produto é obrigatório!")]
        public decimal? Price { get; set; }
    }
}
