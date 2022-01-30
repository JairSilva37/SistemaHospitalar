using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.DomainCore.Base
{
    public interface IGenericRepository<T, Tkey> : IDisposable where T : class
    {
        Task<IEnumerable<T>> SelecionarTodos(Expression<Func<T, bool>> quando = null);
        Task<T> SelecionarPorId(Tkey id);
        Task Inserir(T obj);
        Task Atualizar(T obj);
        Task Excluir(T obj);
        Task ExcluirPorId(Tkey id);

        //Task<int> SaveAsync();
    }
}
