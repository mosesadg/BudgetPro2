namespace BudgetPro2.Migrations
{
    using BudgetPro2.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BudgetPro2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BudgetPro2.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                 new RoleStore<IdentityRole>(context));


            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });

            }



            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            ApplicationUser user;


            if (!context.Users.Any(r => r.UserName == "moses.adg@gmail.com"))
            {
                user = new ApplicationUser

                {
                    UserName = "moses.adg@gmail.com",
                    Email = "moses.adg@gmail.com",
                    FirstName = "Anand",
                    LastName = "Moses",
                    DisplayName = "Anand Moses"
                };
                userManager.Create(user, "ABC123!");
            }

            user = userManager.FindByEmail("moses.adg@gmail.com"); //new addition
            userManager.AddToRole(user.Id, "Admin");//new addition


                        //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
