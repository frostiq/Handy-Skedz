using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Schools")]
    public class SchoolDto : EntityData
    {
        public string Name { get; set; }

        public SchoolTypeDto SchoolType { get; set; }

        public LocationDto Location { get; set; }
    }
}