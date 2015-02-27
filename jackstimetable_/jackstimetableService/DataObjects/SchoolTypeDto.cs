using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("SchoolTypes")]
    public class SchoolTypeDto : EntityData
    {
        public string Name { get; set; }
    }
}