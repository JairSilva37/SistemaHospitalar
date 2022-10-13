using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.DomainCore.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Data.Repository.Base
{
    public abstract class GenericRepository<T, TKey> : IGenericRepository<T, TKey> where T : EntityBase, new()
    {
        protected ITDeveloperDbContext _context;

        protected GenericRepository(ITDeveloperDbContext context)
        {
            _context = context;
        }

        public virtual async Task Atualizar(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            //await SaveAsync();
        }

        public virtual async Task Excluir(T obj)
        {
            _context.Entry(obj).State = EntityState.Deleted;
            //await SaveAsync();
        }

        public virtual async Task ExcluirPorId(TKey id)
        {
            T obj = await SelecionarPorId(id);
            await Excluir(obj);

        }

        public virtual async Task Inserir(T obj)
        {
            _context.Set<T>().Add(obj);
            //await SaveAsync();
        }

        public async Task<T> SelecionarPorId(TKey id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Dispose()
        {
            _context?.DisposeAsync();
        }
        public virtual async Task<IEnumerable<T>> SelecionarTodos(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return await _context.Set<T>().AsNoTracking().ToListAsync();
            }
            return await _context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
        }

        //public virtual async Task<int> SaveAsync()
        //{
        //  return  await _context.SaveChangesAsync();
        //}
    }
}
