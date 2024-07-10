using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdministadorTareasAPI.Models
{
    public class Nota
    {
        [Key]
        public int IdNota { get; set; }
        public string CuerpoNota { get; set; }
        public int IdTarea { get; set; }
    }
}
