
using AutoMapper;
using EnterprisePatterns.Api.Movies.Application.Dto;
using EnterprisePatterns.Api.Movies.Domain.Entity;
using System.Collections.Generic;

namespace EnterprisePatterns.Api.Proyectos.Application.Assembler
{
    public class ProyectoAssembler
    {
        private readonly IMapper _mapper;

        public ProyectoAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<ProyectoDto> toDtoList(List<Proyecto> movieList)
        {
            return _mapper.Map<List<Proyecto>, List<ProyectoDto>>(movieList);
        }
    }
}
