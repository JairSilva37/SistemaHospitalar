using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Domain.Mensageria.Mediators
{
    public interface IMediatorHandler
    {
        Task PulicarEvento<T>(T evento) where T:Event;
    }
}
