using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Schools")]
    public class SchoolDto : EntityData
    {
        public string Name { get; set; }

        public SchoolTypeDto SchoolType { get; set; }

        public CityDto City { get; set; }
    }
}