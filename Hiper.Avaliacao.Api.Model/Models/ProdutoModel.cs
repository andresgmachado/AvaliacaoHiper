using System;
using System.ComponentModel.DataAnnotations;

namespace Hiper.Produto.Api.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(68, ErrorMessage = "maximo 68")]
        [MinLength(2, ErrorMessage = "minimo 2")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Estoque deve ser maior que zero")]
        public Decimal Estoque { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Preço deve ser maior que zero")]
        public Decimal Preco { get; set; }

    }
}
