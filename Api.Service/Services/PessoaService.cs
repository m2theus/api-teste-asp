using Api.Data.Mapping;
using AutoMapper;
using Domain.Dtos.Pessoa;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Pessoa;
using Domain.Models;
using Domain.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PessoaService : IPessoaService
    {

        private IRepository<PessoaEntity> _repository;

        private readonly IMapper _mapper;

        public PessoaService(IRepository<PessoaEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<PessoaDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PessoaDto>(entity);

        }

        public async Task<IEnumerable<PessoaDto>> GetAll(PaginationFilter pagination)

        {
           
            var listEntity = await _repository.SelectAsync(pagination);
        
            return _mapper.Map<IEnumerable<PessoaDto>>(listEntity);

        }

        public async Task<PessoaDtoCreateResult> Post(PessoaDtoCreate pessoa)
        {
            var model = _mapper.Map<PessoaModel>(pessoa);
            var entity = _mapper.Map<PessoaEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<PessoaDtoCreateResult>(result);
        }

        public async Task<PessoaDtoUpdateResult> Put(PessoaDtoUpdate pessoa)
        {
            var model = _mapper.Map<PessoaModel>(pessoa);
            var entity = _mapper.Map<PessoaEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PessoaDtoUpdateResult>(result);
        }
    }
}
