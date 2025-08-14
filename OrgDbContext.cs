using Microsoft.EntityFrameworkCore;
using organizadordeventos.Infrastructure.Models;
namespace organizadordeeventos.Infrastructure.Context

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Invitado> Invitados { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Partida> Presupuesto { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}

