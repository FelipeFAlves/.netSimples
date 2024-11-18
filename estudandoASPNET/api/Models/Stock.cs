using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Stocks")]
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } =  string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")] // A próxima propriedade vai ser um decimal com no maximo
        //18 digitos e 2 deles sendo após a virgula
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")] 
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } =  string.Empty;
        public long MarketCap { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>(); // One to many
        public List<Portifolio> Portifolios {get; set;} = new List<Portifolio>();

    }
}