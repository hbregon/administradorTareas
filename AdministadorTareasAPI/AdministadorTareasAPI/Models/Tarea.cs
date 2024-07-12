using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using System.Threading;

namespace AdministadorTareasAPI.Models
{
    public class Tarea
    {
        //public Tarea()
        //{
        //    Notas = new HashSet<Nota>();
        //}
        [Key]
        public int? IdTarea { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
        public string? Prioridad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        [AllowNull]
        public int? IdColaborador { get; set; }
        [JsonIgnore]
        public virtual Colaborador? ObjetoColaborador { get; set; }
        //[JsonIgnore]
        //public virtual ICollection<Nota> Notas { get; set; }
        public string? Nota { get; set; }
    }
}
