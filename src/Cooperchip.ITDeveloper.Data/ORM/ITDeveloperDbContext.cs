
using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Cooperchip.ITDeveloper.Data.ORM
{
    public class ITDeveloperDbContext : DbContext
    {
        public ITDeveloperDbContext(DbContextOptions<ITDeveloperDbContext> options)
            :base(options)
        {}

        public DbSet<Mural> Mural { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<EstadoPaciente> EstadoPaciente { get; set; }

    }
}
