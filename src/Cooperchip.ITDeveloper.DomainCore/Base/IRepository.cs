using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.DomainCore.Base
{
    public interface IRepository<TEntity, Tkey> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> SelecionarTodos(Expression<Func<TEntity, bool>> quando = null);
        Task<TEntity> SelecionarPorId(Tkey id);
        Task Inserir(TEntity obj);
        Task Atualizar(TEntity obj);
        Task Excluir(TEntity obj);
        Task ExcluirPorId(Tkey id);

        Task<int> SaveAsync();
    }
}
