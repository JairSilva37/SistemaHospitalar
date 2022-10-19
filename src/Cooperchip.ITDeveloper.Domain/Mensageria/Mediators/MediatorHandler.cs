using MediatR;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Domain.Mensageria.Mediators
{
    public class MediatorHandler : IMediatorHandler
    {
        public readonly IMediator _mediator;
        public MediatorHandler(IMediator mediator)
        {
            _mediator=mediator;
        }

        public async Task PulicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }
    }
}
