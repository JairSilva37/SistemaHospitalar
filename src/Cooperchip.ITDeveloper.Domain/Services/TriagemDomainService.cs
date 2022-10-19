using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Interfaces.Repository;
using Cooperchip.ITDeveloper.Domain.Mensageria.Mediators;
using Cooperchip.ITDeveloper.Domain.Mensageria.Notifications;
using Cooperchip.ITDeveloper.Domain.Mensageria.Validations;
using Cooperchip.ITDeveloper.Domain.ServiceContracts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Domain.Services
{
    public class TriagemDomainService : BaseService, ITriagemDomainService
    {
        private readonly IRepositoryTriagem _repositoryTriagem;
        private readonly IMediatorHandler _mediatorHandler;
        public TriagemDomainService(IRepositoryTriagem repositoryTriagem, INotificador notificador, IMediatorHandler mediatorHandler) : base(notificador)
        {
            _repositoryTriagem=repositoryTriagem;
            _mediatorHandler=mediatorHandler;
        }

        public async Task AdicionarTriagem(Triagem triagem)
        {
            if (!ExecutarValidacao(new TriagemValidation(), triagem)) return;

            if (_repositoryTriagem.Buscar(x => x.CodigoPaciente==triagem.CodigoPaciente && x.DataNotificacao==triagem.DataNotificacao
                && x.Mensagem.Trim() ==triagem.Mensagem.Trim()).Result.Any())
            {
                Notificar("Este registro está duplicado");
            }
            await _repositoryTriagem.Inserir(triagem);
        }

        public async Task ExcluirTriagem(Triagem triagem)
        {
            await _repositoryTriagem.Excluir(triagem);
        }

        public async Task ExcluirTriagemPorIdPaciente(Guid pacienteId)
        {
            if (!_repositoryTriagem.Buscar(x => x.CodigoPaciente==pacienteId).Result.Any())
            {
                Notificar("Não existe(m) registro(s) correspondente à busca.");
                return;
            }
            await _repositoryTriagem.ExcluirTriagemPorIdPaciente(pacienteId);
        }

        public void Dispose()
        {
            _repositoryTriagem?.Dispose();
        }
    }
}
