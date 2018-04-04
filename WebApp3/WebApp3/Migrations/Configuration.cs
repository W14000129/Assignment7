namespace WebApp3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using WebApp3.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<WebApp3.Models.WebApp3Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApp3.Models.WebApp3Context context)
        {
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

			context.Categories.AddOrUpdate(x => x.Id,
		new Category() { Id = 1, Name = "Information Systems" },
		new Category() { Id = 2, Name = "Network Security" },
		new Category() { Id = 3, Name = "Software Development" }
		);
			context.Users.AddOrUpdate(x => x.Id,
				new User() { Id = 1, Email = "weylingoodie@yahoo.com", Name = "Weylin Goodie", CreatedOn = "1995-11-10" },
				new User() { Id = 2, Email = "brandongoodie@yahoo.com", Name = "Brandon Goodie", CreatedOn = "1997-10-09" },
				new User() { Id = 3, Email = "raygoodie@yahoo.com", Name = "Ray Goodie", CreatedOn = "1972-02-28" });

			context.Notes.AddOrUpdate(x => x.Id,
				new Notes() { Id = 1, Title = "CSC 435", Note = "Welcome to 435", CreatedOn = "2018-03-28", CategoryId = 1, isDeleted = true, UserId = 1 },
				new Notes() { Id = 2, Title = "CSC 438", Note = "Welcome to 438", CreatedOn = "2018-04-02", CategoryId = 2, isDeleted = false, UserId = 2 },
				new Notes() { Id = 3, Title = "CSC 420", Note = "Welcome to 420", CreatedOn = "2018-03-20", CategoryId = 3, isDeleted = true, UserId = 3 });
		}
    }
}
