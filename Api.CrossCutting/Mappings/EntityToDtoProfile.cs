using Domain.Dtos.Pessoa;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<PessoaDto, PessoaEntity>().ReverseMap();

            CreateMap<PessoaDtoCreateResult, PessoaEntity>().ReverseMap();

            CreateMap<PessoaDtoUpdateResult, PessoaEntity>().ReverseMap();
        }

    }
}
