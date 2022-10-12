﻿using Cooperchip.ITDeveloper.Application.Extensions;
using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    public class CidController : Controller
    {
        private readonly ITDeveloperDbContext _context;

        public CidController(ITDeveloperDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? pagina, string ordenacao, string stringBusca)
        {

            // var usuario = HttpContext.User.Identity.Name;

            const int itensPorPagina = 8;
            int numeroPagina = (pagina ?? 1);

            ViewData["ordenacao"] = ordenacao;
            ViewData["filtroAtual"] = stringBusca;

            var cids = from c in _context.Cid select c;
            //envia para a filtragem qualquer parte que receber do filtro
            if (!string.IsNullOrEmpty(stringBusca)) cids = cids.Where(x => x.Codigo.Contains(stringBusca) || x.Diagnostico.Contains(stringBusca));

            ViewData["OrderByInternalId"] = string.IsNullOrEmpty(ordenacao) ? "CidInternalId_desc" : "";
            ViewData["OrderByCodigo"] = ordenacao == "Codigo" ? "Codigo_desc" : "Codigo";
            ViewData["OrderByDiagnostico"] = ordenacao == "Diagnostico" ? "Diagnostico_desc" : "Diagnostico";

            if (string.IsNullOrEmpty(ordenacao)) ordenacao = "CidInternalId";

            if (ordenacao.EndsWith("_desc"))
            {
                ordenacao = ordenacao.Substring(0, ordenacao.Length - 5);  //remove a palavra _desc da string
                cids = cids.OrderByDescending(x => EF.Property<object>(x, ordenacao)); //tranforma um valor em proproiedade 
            }
            else
            {
                cids = cids.OrderBy(x => EF.Property<object>(x, ordenacao)); //tranforma um valor em proproiedade 
            }

            return View(await cids.ToPagedListAsync(numeroPagina, itensPorPagina));
        }

        public IActionResult ArquivoInvalido()
        {
            TempData["ArquivoInvalido"] = "O arquivo não é inválido";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ImportCid(IFormFile file, [FromServices] IWebHostEnvironment webHostEnvironment)
        {
            if (!ArquivoValido.EhValido(file, "Cid.Csv"))
            {
                return RedirectToAction("ArquivoInvalido");
            }
            var filePah = $"{webHostEnvironment.WebRootPath}\\importFiles\\{file.FileName}";

            CopiarArquivo.Copiar(file, filePah);

            int k = 0;
            string line;

            List<Cid> cids = new List<Cid>();
            Encoding encodingPage = Encoding.GetEncoding(1252);
            bool detectEncoding = false;

            using (var fs = System.IO.File.OpenRead(filePah))
            using (var stream = new StreamReader(fs, encoding: encodingPage, detectEncoding))
                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(";");
                    //pula cabeçalho
                    if (k > 0)
                    {
                        if (!_context.Cid.Any(x => x.CidInternalId == int.Parse(parts[0])))
                        {
                            cids.Add(new Cid
                            {
                                CidInternalId = int.Parse(parts[0]),
                                Codigo = parts[1],
                                Diagnostico = parts[2]
                            });
                        }
                    }
                    k++;
                }
            if (cids.Any())
            {
                await _context.AddRangeAsync(cids);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var cid = await _context.Cid.FirstOrDefaultAsync(x => x.Id == id);
            if (cid == null) return NotFound();
            return View(cid);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cid cid)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(cid);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                //return RedirectToAction(nameof(Index));
            }
            return View(cid);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var cid = await _context.Cid.FindAsync(id);
            if (cid == null) return NotFound();
            return View(cid);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Cid cid)
        {
            if (id != cid.Id) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cid);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CidExists(cid.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                //return RedirectToAction(nameof(Index));
            }
            return View(cid);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var cid = await _context.Cid.FirstOrDefaultAsync(x => x.Id == id);
            if (cid == null) return NotFound();
            return View(cid);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var cid = await _context.Cid.FindAsync(id);
            _context.Remove(cid);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CidExists(Guid id)
        {
            return _context.Cid.Any(x => x.Id == id);
        }
    }
}
