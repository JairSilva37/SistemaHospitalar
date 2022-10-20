using AutoMapper;
using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Interfaces;
using Cooperchip.ITDeveloper.Domain.Interfaces.Repository;
using Cooperchip.ITDeveloper.Domain.Mensageria.Notifications;
using Cooperchip.ITDeveloper.Mvc.ServiceApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    public class TriagemController : BaseController
    {
        private readonly IRepositoryTriagem _repositoryTriagem;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TriagemController(IRepositoryTriagem repositoryTriagem, IUnitOfWork unitOfWork, IMapper mapper, INotificador notificador) : base(notificador)
        {
            _repositoryTriagem=repositoryTriagem;
            _unitOfWork=unitOfWork;
            _mapper=mapper;
        }

        [HttpGet("listagem-notificacoes")]
        public async Task<IActionResult> Index()
        {
            var lista = _mapper.Map<IEnumerable<TriagemViewModel>>(await _repositoryTriagem.SelecionarTodos());
            return View(lista);
        }

        [HttpGet("triagem-para-prontuario/{id:guid}")]
        public async Task<IActionResult> Triagem(Guid id)
        {
            var triagem = _mapper.Map<TriagemViewModel>(await _repositoryTriagem.ObterTriagemPorId(id));
            if (triagem==null) return BadRequest();

            return View(triagem);
        }


        [HttpGet("nova-triagem")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("nova-triagem")]
        public async Task<IActionResult> Create(TriagemViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _repositoryTriagem.Inserir(_mapper.Map<Triagem>(model));
                if (!OperacaoValida()) return View(model);
                await _unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet("excluir-triagem/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var triagem = _mapper.Map<TriagemViewModel>(await _repositoryTriagem.ObterTriagemPorId(id));
            if (triagem==null) return NotFound();

            return View(triagem);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _repositoryTriagem.ExcluirPorId(id);
            await _unitOfWork.Commit();

            return RedirectToAction(nameof(Index));
        }
    }
}
