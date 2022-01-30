using AutoMapper;
using Cooperchip.ITDeveloper.Application.ViewModels;
using Cooperchip.ITDeveloper.Data.Repository.Abstractions;
using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Interfaces;
using Cooperchip.ITDeveloper.Domain.Interfaces.ServiceContracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PacienteController : Controller
    {
        private readonly IUnitOfWork _uow; // metodo para salvar tudo ou salva nada 
        private readonly IQueryPaciente _queryRepo;//responsável somente por metodos de consultas
        private readonly IPacienteDomainService _serverDomain; //responsável por metodos de Edição e gravação
        private readonly IMapper _mapper;

        public PacienteController(IQueryPaciente queryRepo, IPacienteDomainService serverDomain, IMapper mapper, IUnitOfWork uow)
        {
            _queryRepo = queryRepo;
            _serverDomain = serverDomain;
            _mapper = mapper;
            _uow = uow;
        }


        // GET: Paciente
        //public async Task<IActionResult> Index()
        //{
        //    return View(_mapper.Map<IEnumerable<PacienteViewModel>>(await _repoPaciente.ListaPacientesComEstado()));
        //}

        //INDEX COM AUTOMAPER NA MÃO
        #region INDEX COM MAPPER NA MÃO 
        public async Task<IActionResult> Index()
        {

            var pacientes = await _queryRepo.ListaPacientesComEstado();
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

            return View(listaView);
        }
        #endregion


        public async Task<IActionResult> Details(Guid id)
        {
            var paciente = _mapper.Map<PacienteViewModel>(await _queryRepo.ObterPacienteComEstadoPaciente(id));
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        [HttpGet]
        public async Task<IActionResult> ReportForEstadoPaciente(Guid id)
        {
            var pacientePorEstado = _mapper.Map<IEnumerable<PacienteViewModel>>(await _queryRepo.ObterPacientesPorEstadoPaciente(id));
            if (pacientePorEstado == null) NotFound();
            return View(pacientePorEstado);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.EstadoPaciente = new SelectList(await _queryRepo.ListaEstadoPaciente(), "Id", "Descricao");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PacienteViewModel paciente)
        {
            if (ModelState.IsValid)
            {
                //paciente.Id = Guid.NewGuid(); // Não Usar
                await _serverDomain.AdicionarPaciente(_mapper.Map<Paciente>(paciente));
                //Outros processos dentro de meso repositorio
                //..
                //..


                await _uow.Commit();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            ViewBag.EstadoPaciente = new SelectList(await _queryRepo.ListaEstadoPaciente(), "Id", "Descricao", paciente.EstadoPacienteId);
            return View(paciente);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var paciente = _mapper.Map<PacienteViewModel>(await _queryRepo.ObterPacienteComEstadoPaciente(id));

            if (paciente == null)
            {
                return NotFound();
            }
            ViewBag.EstadoPaciente = new SelectList(await _queryRepo.ListaEstadoPaciente(), "Id", "Descricao", paciente.EstadoPacienteId);
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
                    await _serverDomain.AtualizarPaciente(_mapper.Map<Paciente>(paciente));
                    //Outros processos dentro de meso repositorio
                    //..
                    //..
                    await _uow.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.Id))
                    {
                        await _uow.Rollback();
                        return NotFound();
                    }
                    else
                    {
                        await _uow.Rollback();
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.EstadoPaciente = new SelectList(await _queryRepo.ListaEstadoPaciente(), "Id", "Descricao", paciente.EstadoPacienteId);
            return View(paciente);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {

            var paciente = _mapper.Map<PacienteViewModel>(await _queryRepo.ObterPacienteComEstadoPaciente(id));

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
            var paciente = await _queryRepo.SelecionarPorId(id);

            await _serverDomain.ExcluirPaciente(paciente);
            //Outros processos dentro de meso repositorio
            //..
            //..
            await _uow.Commit();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteExists(Guid id)
        {
            return _queryRepo.TemPaciente(id);
        }
    }
}

