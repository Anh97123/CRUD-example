namespace LibManage1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LibManage1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LibManage1.Models.LibManage1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibManage1.Models.LibManage1Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(x => x.ProductId,
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Extending Bootstrap with CSS, JavaScript and jQuery",
                    IntroductionDate = Convert.ToDateTime("6/11/2015"),
                    Url = "http://bit.ly/1SNzc0i"
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Build your own Bootstrap Business Application Template in MVC",
                    IntroductionDate = Convert.ToDateTime("1/29/2015"),
                    Url = "http://bit.ly/1I8ZqZg"
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Building Mobile Web Sites Using Web Forms, Bootstrap, and HTML5",
                    IntroductionDate = Convert.ToDateTime("8/28/2014"),
                    Url = "http://bit.ly/1J2dcrj"
                });
        }
    }
}
