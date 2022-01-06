using Cooperchip.ITDeveloper.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cooperchip.ITDeveloper.Data.ORM
{
    public class ITDeveloperDbContext:DbContext
    {
        public ITDeveloperDbContext(DbContextOptions<ITDeveloperDbContext>options):base(options)
        {

        }

        public DbSet<Mural> Mural { get; set; }
    }
}
