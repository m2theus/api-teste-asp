using Domain.Dtos.Pessoa;
using Domain.Entities;
using Domain.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Pessoa
{
    public interface IPessoaService
    {
        Task<PessoaDto> Get(Guid id);

        Task<IEnumerable<PessoaDto>> GetAll(PaginationFilter pagination);

        Task<PessoaDtoCreateResult> Post(PessoaDtoCreate pessoa);

        Task<PessoaDtoUpdateResult> Put(PessoaDtoUpdate pessoa);

        Task<bool> Delete(Guid id);

    }
}
