using organizadordeventos.Domain.Entities;
using organizadordeeventos.Infrastructure.Context;
using organizadordeventos.Infrastructure.Core;
using organizadordeventos.Infrastructure.Interfaces;

namespace organizadordeventos.Infrastructure.Repositories
{
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {
        public EventoRepository(OrgDbContext context) : base(context)
        {
        }
        
        // Implementar métodos específicos adicionales aquí si los necesitas
    }
}