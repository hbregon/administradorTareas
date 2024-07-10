using Microsoft.EntityFrameworkCore;
namespace AdministadorTareasAPI.Models
{
    public class TareaContexto : DbContext
    {
        public TareaContexto(DbContextOptions<TareaContexto> opciones) : base(opciones) { }

        public DbSet<Tarea> Tareas { get; set; } = null!;
    }
}
