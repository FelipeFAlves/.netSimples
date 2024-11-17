using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5,ErrorMessage = "Titulo deve ter ao menos 5 letras")]
        [MaxLength(280,ErrorMessage = "Titulo não pode possuir mais que 280 letras")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5,ErrorMessage = "Titulo deve ter ao menos 5 letras")]
        [MaxLength(280,ErrorMessage = "Titulo não pode possuir mais que 280 letras")]
        public string Content { get; set; } = string.Empty;
    }
}