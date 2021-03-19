using HWebTS.Common.Identity.Context;
using HWebTS.Common.Identity.Users;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace HWebTS.Common.Identity.Migrations
{
    public class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {

            const string fullName = "System Administrator";
            const string userName = "Administrator";
            const string email = "ailtonemilio@hotmail.com";
            const string password = "Ae190273$";
            const string roleName = "Admin";
            const string userImage = "usericon.png";
            DateTime lastAccess = Convert.ToDateTime("2019-08-11");

            // Verificar se já existe uma role chamada Admin (nossa constante acima) Caso não haja criaremos uma;
            if (!context.Roles.Any(r => r.Name == roleName))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = roleName };
                manager.Create(role);
            }

            // Verificar se existe um usuário na base de dados (user admin inicial) Se não houver criaremos um usuário padrão
            if (!context.Users.Any(u => u.UserName == userName))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    UserName = userName,
                    FullName = fullName,
                    Email = email,
                    UserImage = userImage,
                    LastAccess = lastAccess
                };
                manager.Create(user, password);
                manager.AddToRole(user.Id, roleName);
            }

            base.Seed(context);
        }
    }
}
