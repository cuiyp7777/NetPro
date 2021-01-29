namespace WebMvc5.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebMvc5.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebMvc5.DAL.AccountContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebMvc5.DAL.AccountContext";
        }

        protected override void Seed(WebMvc5.DAL.AccountContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //通过context将entities添加到database中去
        }
    }
}
