using Cooperchip.ITDeveloper.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Cooperchip.ITDeveloper.CrossCutting.Auxiliar
{
    public class UserInAllLayer : IUserInAllLayer
    {
        private readonly IUserInContext _user;
        public UserInAllLayer(IUserInContext user)
        {
            _user = user;
        }

        public IDictionary<string, string> DictonaryOfCaimss()
        {
            var email = "";
            IDictionary<string, string> minhasCaims = new Dictionary<string, string>();

            if (_user.IsAuthenticated())
            {

                minhasCaims.Add("Apelido", _user.GetUserApelido());
                minhasCaims.Add("Nome Comleto", _user.GetUserNomeCompleto());
                minhasCaims.Add("Imagem do Perfil", _user.GetUserImgProfilePath());
                minhasCaims.Add("Id", _user.GetUserId().ToString());
                minhasCaims.Add("Nome", _user.Name);
                minhasCaims.Add("Email", _user.GetUserEmail());
                minhasCaims.Add("E Administrador", _user.IsInRole("Admin") ? "SIM" : "NÃO");


                var nome = minhasCaims["Nome"];
                email = minhasCaims["Email"];
                var EhAdministrador = minhasCaims["E Administrador"];

            }

            return minhasCaims;
        }

        public IEnumerable<Claim> LisOfClaims()
        {
            var claimsOfUser = _user.GetClaimsIdentity();
            return claimsOfUser;
        }
    }
}
