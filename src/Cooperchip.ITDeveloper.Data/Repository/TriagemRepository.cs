﻿using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.Data.Repository.Base;
using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Data.Repository
{
    public class TriagemRepository : GenericRepository<Triagem, Guid>, IRepositoryTriagem
    {
        public TriagemRepository(ITDeveloperDbContext context) : base(context)
        {
        }


        public async Task<Triagem> ObterTriagemPorId(Guid id)
        {
            return await _context.Set<Triagem>().FirstOrDefaultAsync(x => x.CodigoPaciente ==id);
        }
        public async Task<IEnumerable<Triagem>> ListagemTriagemPorData()
        {
            return await _context.Set<Triagem>().AsNoTracking().OrderBy(x => x.DataNotificacao).ToListAsync();

        }
        public async Task<Triagem> ObterTriagemPorIdPaciente(Guid pacienteId)
        {
            return await _context.Set<Triagem>().FirstOrDefaultAsync(x => x.CodigoPaciente==pacienteId);

        }

        public async Task ExcluirTriagemPorIdPaciente(Guid pacienteId)
        {
            var result = await ObterTriagemPorIdPaciente(pacienteId);

            _context.Entry(result).State=EntityState.Detached;
            await _context.SaveChangesAsync();
            _context.Entry(result).State=EntityState.Detached;
        }

    }
}
