using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using JackstimetableService.DataObjects;
using JackstimetableService.Models;
using Microsoft.WindowsAzure.Mobile.Service;
using System.Data.Entity.Migrations;
using JackstimetableService.Migrations;

namespace JackstimetableService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            
            Database.SetInitializer(new ClearDatabaseSchemaAlways<JackstimetableContext>());

            //var migrator = new DbMigrator(new Configuration());
            //migrator.Update();
        }
    }
}

