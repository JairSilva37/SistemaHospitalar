using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Domain.Entities.Audit
{
    public abstract class EntityAudit :EntityBase, IAuditable
    {
        public EntityAudit()
        {

        }
        public  DateTime? DataInclusao { get; set; }
        public  string UsuarioInclusao { get; set; }
        public  DateTime? DataUltimaModificacao { get; set; }
        public  string UsuarioUltimaModificacao { get; set; }
    }
}
