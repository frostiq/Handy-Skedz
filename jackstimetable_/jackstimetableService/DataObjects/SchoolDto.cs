using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Schools")]
    public class SchoolDto : EntityData
    {
        public string Name { get; set; }

        public string SchoolTypeId { get; set; }
        
        public virtual SchoolTypeDto SchoolType { get; set; }

        public string CityId { get; set; }

        public virtual CityDto City { get; set; }
    }
}