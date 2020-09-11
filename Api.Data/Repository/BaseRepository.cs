using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Wrappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly MyContext _context;
        private DbSet<T> _dataset;


        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = context.Set<T>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {

                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

                if (result == null)
                {
                    return false;
                }

                _dataset.Remove(result);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return item;
        }



        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync(PaginationFilter pagination)
        {
            try
            {
                var validFilter = new PaginationFilter(pagination.PageNumber, pagination.PageSize);
                return await _dataset.Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
               .Take(validFilter.PageSize)
               .ToListAsync();


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null)
                {
                    return null;
                }

                _context.Entry(result).CurrentValues.SetValues(item);


                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return item;
        }
    }
}
