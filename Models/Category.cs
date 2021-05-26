using System.ComponentModel.DataAnnotations;

namespace teste_ef.Models
{


    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
        public string Title {get; set;}
    }
}