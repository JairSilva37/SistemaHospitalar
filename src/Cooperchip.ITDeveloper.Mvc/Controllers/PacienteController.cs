using Cooperchip.ITDeveloper.Application.Interfaces;
using Cooperchip.ITDeveloper.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PacienteController : Controller
    {
        private readonly IServicoAplicacaoPaciente _serviceApp;    

        public PacienteController(IServicoAplicacaoPaciente serviceApp)
        {
            _serviceApp = serviceApp;        
        }

        // GET: Paciente
        public async Task<IActionResult> Index()
        {
            //AQUI USANDO O AUTOMAPPER 
            return View(await _serviceApp.ObterPacientesComEstadoPacienteApplication());

            //AQUI ESCREVENDO NA MÃO
            //return View(await _serviceApp.ObterPacientesDePacienteViewModelApplication());       
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var paciente = await _serviceApp.ObterPacienteComEstadoPacienteApplication(id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        public async Task<IActionResult> ReportForEstadoPaciente(Guid id)
        {
            var pacientePorEstado = await _serviceApp.ObterPacientesPorEstadoPacienteApplication(id);
            if (pacientePorEstado == null) NotFound();
            return View(pacientePorEstado);
        }

        public async Task< IActionResult >Create()
        {
            ViewBag.EstadoPaciente = new SelectList(await _serviceApp.ListaEstadoPacienteApplication(), "Id", "Descricao");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PacienteViewModel paciente)
        {
            if (ModelState.IsValid)
            {
                //paciente.Id = Guid.NewGuid(); // Não Usar
                await _serviceApp.AdicionarPacienteApplication(paciente);
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            ViewBag.EstadoPaciente = new SelectList(await _serviceApp.ListaEstadoPacienteApplication(), "Id", "Descricao", paciente.EstadoPacienteId);
            return View(paciente);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var paciente = await _serviceApp.ObterPacienteComEstadoPacienteApplication(id);
            if (paciente == null)
            {
                return NotFound();
            }
            ViewBag.EstadoPaciente = new SelectList(await _serviceApp.ListaEstadoPacienteApplication(), "Id", "Descricao", paciente.EstadoPacienteId);
            return View(paciente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, PacienteViewModel paciente)
        {
            if (id != paciente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _serviceApp.AtualizarPacienteApplication(paciente);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.EstadoPaciente = new SelectList(await _serviceApp.ListaEstadoPacienteApplication(), "Id", "Descricao", paciente.EstadoPacienteId);
            return View(paciente);
        }

        public async Task< IActionResult >Delete(Guid id)
        {

            var paciente =await  _serviceApp.ObterPacienteComEstadoPacienteApplication(id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _serviceApp.RemoverPacienteApplication(id);
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteExists(Guid id)
        {
            return _serviceApp.TemPacienteApplication(id);
        }
    }
}
