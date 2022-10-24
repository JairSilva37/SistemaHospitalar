using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Interfaces;
using Cooperchip.ITDeveloper.Domain.Interfaces.Repository;
using Cooperchip.ITDeveloper.Domain.Mensageria.Mediators;
using Cooperchip.ITDeveloper.Domain.Mensageria.Notifications;
using Cooperchip.ITDeveloper.Domain.Mensageria.Validations;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Domain.Services
{
    public class ServiceDomainMural : BaseService, IMuralService
    {
        private readonly IMediatorHandler _bus;
        private readonly IRepositoryMural _repositoryMural;
        public ServiceDomainMural(INotificador notification, IMediatorHandler bus,
            IRepositoryMural repositoryMural) : base(notification)
        {
            _bus=bus;
            _repositoryMural=repositoryMural;
        }

        public async Task AdicionarMural(Mural model)
        {
            if (!ExecutarValidacao(new MuralValidation(), model)) return;

            if (_repositoryMural.Buscar(m => m.Id==model.Id).Result.Any())
            {
                Notificar("Já existe um registro já foi cadastrado!");
                return;
            }


            await _repositoryMural.Inserir(model);
            //await _bus.PulicarEvento(new MuralCadastradoEvent(model.Data, model.Titulo, model.Autor, model.Titulo));

        }

        public async Task AtualizarMural(Mural model)
        {

            if (!ExecutarValidacao(new MuralValidation(), model)) return;

            if (_repositoryMural.Buscar(m => m.Titulo.Trim() ==model.Titulo.Trim() && m.Autor==model.Autor &&
                 m.Data ==model.Data && m.Aviso.Trim()==model.Aviso.Trim()).Result.Any())
            {
                Notificar("Não foram modificados !");
                return;
            }
            await _repositoryMural.Atualizar(model);
        }


        public async Task ExcluirMural(Mural model)
        {
            await _repositoryMural.Excluir(model);
        }

        public void Dispose()
        {
            _repositoryMural?.Dispose();
        }
    }
}
