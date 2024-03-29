﻿using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Interfaces.Repository;
using Cooperchip.ITDeveloper.Domain.Interfaces.ServiceContracts;
using Cooperchip.ITDeveloper.Domain.Mensageria.EventPublish;
using Cooperchip.ITDeveloper.Domain.Mensageria.Mediators;
using Cooperchip.ITDeveloper.Domain.Mensageria.Notifications;
using Cooperchip.ITDeveloper.Domain.Mensageria.Validations;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Domain.Interfaces.Services
{
    public class PacienteDomainService : BaseService, IPacienteDomainService
    {
        private readonly IRepositoryPaciente _repo;
        private readonly IMediatorHandler _mediatorHandler;
        public PacienteDomainService(IRepositoryPaciente repo, INotificador notificador, IMediatorHandler mediatorHandler) : base(notificador)
        {
            _repo = repo;
            _mediatorHandler=mediatorHandler;
        }

        public async Task AdicionarPaciente(Paciente paciente)
        {
            if (!ExecutarValidacao(new PacienteValidation(), paciente))
            {
                return;
            }

            if (_repo.Buscar(x => x.Cpf== paciente.Cpf).Result.Any())
            {
                Notificar("Já existe um  paciente com o CPF informado.");
                return;
            }
            await _repo.InserirPacienteComEstadoPaciente(paciente);
            await _mediatorHandler.PulicarEvento(new PacienteCadastradoEvent(paciente.Id, paciente,paciente.Motivo));

        }

        public async Task AtualizarPaciente(Paciente paciente)
        {

            if (!ExecutarValidacao(new PacienteValidation(), paciente))
            {
                return;
            }

            if (_repo.Buscar(x => x.Cpf== paciente.Cpf && x.EstadoPacienteId !=paciente.EstadoPacienteId).Result.Any())
            {
                Notificar("Já existe um  paciente com o CPF informado.");
                return;
            }

            await _repo.Atualizar(paciente);
        }

        public async Task ExcluirPaciente(Paciente paciente)
        {
            await _repo.Excluir(paciente);
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
