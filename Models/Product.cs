using System.ComponentModel.DataAnnotations;

namespace teste_ef.Models
{


    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Esse campo deve conter no maximo 1024")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior do que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Invalida")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}