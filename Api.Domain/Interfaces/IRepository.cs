﻿using Domain.Entities;
using Domain.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);

        Task<T> UpdateAsync(T item);

        Task<bool> DeleteAsync(Guid id);

        Task<T> SelectAsync(Guid id);

        Task<IEnumerable<T>> SelectAsync(PaginationFilter pagination);

        Task<bool> ExistAsync(Guid id);

    }
}
