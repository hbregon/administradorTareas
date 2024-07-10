using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AdministadorTareasAPI.Models
{
    public class Colaborador
    {
        [Key]
        public int IdColaborador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
