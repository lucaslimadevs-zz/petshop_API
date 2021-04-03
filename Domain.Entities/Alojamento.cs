using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("alojamento")]
    public class Alojamento
    {
        [Dapper.Contrib.Extensions.Key]        
        public int id_alojamento { get; set; }       
        [Required(ErrorMessage = "descrição é obrigatória")]
        public string descricao { get; set; }

    }
}
