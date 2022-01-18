using Cooperchip.ITDeveloper.Domain.Models;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Reflection;

namespace Cooperchip.ITDeveloper.Mvc.Extensions.ExtensionsMethods
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder AddUserAndRole(this ModelBuilder builder)
        {
            const string NOMECOMPLETO = "Jair Silva Administrador";
            const string APELIDO = "Jair Silva";
            //DateTime DATANASCIMENTO = DateTime.Now;
            const string EMAIL = "jairrss@hotmail.com";
            const string PASSWORD = "Abcd1234*";
            const string ROLENAME = "Admin";
            const string USERNAME = EMAIL;

            const string ROLEID = "4218D398-2590-43CE-A0CF-03742FA920C4";
            const string USERID = "006180EB-7739-441C-A60E-68922AD34806";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLEID,
                    Name = ROLENAME,
                    NormalizedName = ROLENAME.ToUpper()
                });

            var phash = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = USERID,
                    Apelido = APELIDO,
                    NomeCompleto = NOMECOMPLETO,
                    DataNascimento = DateTime.Now,
                    Email = EMAIL,
                    NormalizedEmail = EMAIL.ToUpper(),
                    UserName = USERNAME,
                    NormalizedUserName = USERNAME.ToUpper(),
                    PasswordHash = phash.HashPassword(null, PASSWORD),
                    EmailConfirmed = true
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ROLEID,
                    UserId = USERID
                });
            return builder;
        }

        public static ModelBuilder AddGenericos(this ModelBuilder builder)
        {
            var k = 0;
            string line;
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var csvPath = Path.Combine(outPutDirectory, "Csv\\Generico.CSV");
            string filePath = new Uri(csvPath).LocalPath;

            using (var fs = File.OpenRead(filePath))
            using (var reader = new StreamReader(fs))

                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    var codigo = parts[0];
                    var generico = parts[1];

                    if (k > 0)
                    {
                        builder.Entity<Generico>().HasData(
                            new Generico
                            {
                                Codigo = Convert.ToInt32(codigo),
                                Nome = generico
                            });
                    }
                    k++;
                }

            return builder;
        }
    }
}
