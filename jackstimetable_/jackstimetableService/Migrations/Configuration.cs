using System.Collections.Generic;
using JackstimetableService.DataObjects;
using JackstimetableService.Models;

namespace JackstimetableService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
