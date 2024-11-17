using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10,ErrorMessage = "Symbol não pode ter mais que 10 letras")]
        public string Symbol { get; set; } =  string.Empty;
        [Required]
        [MaxLength(10,ErrorMessage = "Nome da empresa nao pode ter mais que 10 letras")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1,1000000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001,100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage = "Nome da industria não pode ter masi que 10 caracteres")]
        public string Industry { get; set; } =  string.Empty;
        [Range(1,5000000000)]
        public long MarketCap { get; set; }
    }
}