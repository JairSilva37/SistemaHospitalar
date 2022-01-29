using System.Collections.Generic;
using System.Security.Claims;

namespace Cooperchip.ITDeveloper.Domain.Interfaces
{
    public interface IUserInAllLayer
    {
        IDictionary<string, string> DictonaryOfCaimss();
        IEnumerable<Claim> LisOfClaims();
    }
}
