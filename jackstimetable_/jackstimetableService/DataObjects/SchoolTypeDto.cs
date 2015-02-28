using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("SchoolTypes")]
    public class SchoolTypeDto : EntityData
    {
        public string Name { get; set; }
    }
}