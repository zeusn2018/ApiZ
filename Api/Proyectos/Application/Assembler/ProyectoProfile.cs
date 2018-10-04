

using AutoMapper;
using EnterprisePatterns.Api.Movies.Application.Dto;
using EnterprisePatterns.Api.Movies.Domain.Entity;

//namespace EnterprisePatterns.Api.Proyectos.Application.Assembler
namespace EnterprisePatterns.Api.BankAccounts.Application.Assembler
{
    public class ProyectoProfile : Profile
    {
        public ProyectoProfile()
        {
            CreateProyecto<Proyecto, ProyectoDto>()
                .ForMember(
                    dest => dest.Usuario,
                    x => x.MapFrom(src => src.Usuario.Name)
                )
                .ForMember(
                    dest => dest.MpaaRating,
                    x => x.MapFrom(src => src.MpaaRating.ToString())
                );
        }
    }
}

