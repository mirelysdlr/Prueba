using AutoMapper;

namespace organizadordeventos.Domain.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Evento mappings
            CreateMap<Entities.Evento, DTOs.EventoReadDto>();
            CreateMap<DTOs.EventoCreateDto, Entities.Evento>();
            CreateMap<DTOs.EventoUpdateDto, Entities.Evento>();
        }
    }
}