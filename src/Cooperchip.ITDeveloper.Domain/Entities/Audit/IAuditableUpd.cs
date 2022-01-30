using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Domain.Entities.Audit
{
    public interface IAuditableUpd
    {
         DateTime? DataUltimaModificacao { get; set; }
         string UsuarioUltimaModificacao { get; set; }
    }
}
