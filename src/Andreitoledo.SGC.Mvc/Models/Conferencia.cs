using Andreitoledo.SGC.Mvc.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andreitoledo.SGC.Mvc.Models
{
    
    public class Conferencia : BaseEntity
    {
        [Column("trilha")]
        [Required(ErrorMessage = "Digite a trilha da conferência")]
        public string Trilha { get; set; }

        [Column("nome")]
        [Required(ErrorMessage = "Digite o nome da conferência")]
        public string Nome { get; set; }

        [Column("tempo")]
        [Required(ErrorMessage = "Digite o tempo de duração da conferência")]
        public string Tempo { get; set; }
    }
}
