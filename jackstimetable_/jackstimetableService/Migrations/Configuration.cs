using System.Data.Entity.Migrations;
using JackstimetableService.Models;

namespace JackstimetableService.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<JackstimetableContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JackstimetableContext context)
        {
            base.Seed(context);
        }
    }
}
