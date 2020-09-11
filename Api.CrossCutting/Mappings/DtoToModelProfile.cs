using AutoMapper;
using Domain.Dtos.Pessoa;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<PessoaModel, PessoaDto>().ReverseMap();
            CreateMap<PessoaModel, PessoaDtoCreate>().ReverseMap();
            CreateMap<PessoaModel, PessoaDtoUpdate>().ReverseMap();
        }
    }
}
