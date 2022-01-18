using Cooperchip.ITDeveloper.Mvc.Data;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Identity.Services
{
    public static class CriaUsersAndRoles
    {
        public static async Task Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            const string nomecompleto = "Jair Silva Administrador";
            const string apelido = "Jair Silva";
            var datanascimento = DateTime.Now;
            const string email = "jairrss@hotmail.com";
            const string password = "Abcd1234*";
            const string roleName = "Admin";
            const string username = email;

            context.Database.Migrate();

            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            if (await userManager.FindByNameAsync(username) == null)
            {
                var user = new ApplicationUser
                {
                    Apelido = apelido,
                    NomeCompleto = nomecompleto,
                    DataNascimento = datanascimento,
                    UserName = username,
                    Email = email,
                    PhoneNumber = "91985457845",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }

}
