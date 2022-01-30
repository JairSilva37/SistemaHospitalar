using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Domain.Entities.Audit
{
   public interface IAuditableAdd
    {
         DateTime? DataInclusao { get; set; }
         string UsuarioInclusao { get; set; }
    }
}
