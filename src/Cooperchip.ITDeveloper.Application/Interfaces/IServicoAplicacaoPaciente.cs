using Cooperchip.ITDeveloper.Application.ViewModels;
using Cooperchip.ITDeveloper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Application.Interfaces
{
    public interface IServicoAplicacaoPaciente
    {
        Task<IEnumerable<PacienteViewModel>> ObterPacientesComEstadoPacienteApplication();
        Task<IEnumerable<PacienteViewModel>> ObterPacientesDePacienteViewModelApplication();
        Task<PacienteViewModel> ObterPacienteComEstadoPacienteApplication(Guid pacienteId);
        Task<IEnumerable<PacienteViewModel>> ObterPacientesPorEstadoPacienteApplication(Guid estadoPacienteId);
        Task<List<EstadoPaciente>> ListaEstadoPacienteApplication();

        bool TemPacienteApplication(Guid pacienteId);
    }
}
