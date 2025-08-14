using AutoMapper;
using organizadordeventos.Domain.DTOs;
using organizadordeventos.Domain.Entities;
using AutoMapper;
using organizadordeventos.Domain.DTOs;
using organizadordeventos.Domain.Entities;

namespace organizadordeventos.Domain.Mapping
{
    public class EventoProfile : Profile
    {
        public EventoProfile()
        {
            // Entity → ReadDto
            CreateMap<Evento, EventoReadDto>()
                .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Lugar));

            // CreateDto → Entity
            CreateMap<EventoCreateDto, Evento>()
                .ForMember(dest => dest.Lugar, opt => opt.MapFrom(src => src.Ubicacion));

            // UpdateDto → Entity
            CreateMap<EventoUpdateDto, Evento>()
                .ForMember(dest => dest.Lugar, opt => opt.MapFrom(src => src.Ubicacion));
        }
    }
}
