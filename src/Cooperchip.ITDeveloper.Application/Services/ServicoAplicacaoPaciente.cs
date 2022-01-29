using AutoMapper;
using Cooperchip.ITDeveloper.Application.Interfaces;
using Cooperchip.ITDeveloper.Application.ViewModels;
using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Interfaces;
using Cooperchip.ITDeveloper.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Application.Services
{
    public class ServicoAplicacaoPaciente : IServicoAplicacaoPaciente
    {

        private readonly IRepositoryPaciente _repoPaciente;
        private readonly IPacienteDomainService _serverDomain;
        private readonly IMapper _mapper;

        public ServicoAplicacaoPaciente(IRepositoryPaciente repoPaciente, IMapper mapper, IPacienteDomainService serverDomain)
        {
            _repoPaciente = repoPaciente;
            _mapper = mapper;
            _serverDomain = serverDomain;
        }

        public async Task<PacienteViewModel> ObterPacienteComEstadoPacienteApplication(Guid pacienteId)
        {
            return _mapper.Map<PacienteViewModel>(await _repoPaciente.ObterPacienteComEstadoPaciente(pacienteId));
        }



        #region QUERIES METHODS
        public async Task<IEnumerable<PacienteViewModel>> ObterPacientesComEstadoPacienteApplication()
        {
            return _mapper.Map<IEnumerable<PacienteViewModel>>(await _repoPaciente.ListaPacientesComEstado());
        }

        public async Task<IEnumerable<PacienteViewModel>> ObterPacientesPorEstadoPacienteApplication(Guid estadoPacienteId)
        {
            return _mapper.Map<IEnumerable<PacienteViewModel>>(await _repoPaciente.ObterPacientesPorEstadoPaciente(estadoPacienteId));
        }

        #region MAPPER NA MÃO
        public async Task<IEnumerable<PacienteViewModel>> ObterPacientesDePacienteViewModelApplication()
        {
            var pacientes = await _repoPaciente.ListaPacientesComEstado();
            List<PacienteViewModel> listaView = new List<PacienteViewModel>();

            foreach (var item in pacientes)
            {
                listaView.Add(new PacienteViewModel
                {
                    Ativo = item.Ativo,
                    Cpf = item.Cpf,
                    DataInternacao = item.DataInternacao,
                    DataNascimento = item.DataNascimento,
                    Email = item.Email,
                    EstadoPaciente = item.EstadoPaciente,
                    EstadoPacienteId = item.EstadoPacienteId,
                    Id = item.Id,
                    Nome = item.Nome,
                    Rg = item.Rg,
                    RgDataEmissao = item.RgDataEmissao,
                    RgOrgao = item.RgOrgao,
                    Sexo = item.Sexo,
                    TipoPaciente = item.TipoPaciente,
                    Motivo = item.Motivo
                });

            }


            return listaView;

        }

        #endregion

        public async Task<List<EstadoPaciente>> ListaEstadoPacienteApplication()
        {
            return await _repoPaciente.ListaEstadoPaciente();
        }

        public bool TemPacienteApplication(Guid pacienteId)
        {
            return _repoPaciente.TemPaciente(pacienteId);
        }

        public async Task AdicionarPacienteApplication(PacienteViewModel pacienteViewModel)
        {
            await _serverDomain.AdicionarPaciente(_mapper.Map<Paciente>(pacienteViewModel));
        }

        public async Task AtualizarPacienteApplication(PacienteViewModel pacienteViewModel)
        {
            await _serverDomain.AtualizarPaciente(_mapper.Map<Paciente>(pacienteViewModel));
        }

        public async Task RemoverPacienteApplication(Guid id)
        {
            var paciente = await _repoPaciente.SelecionarPorId(id);
            await _serverDomain.ExcluirPaciente(paciente);
        }

        #endregion
    }
}
