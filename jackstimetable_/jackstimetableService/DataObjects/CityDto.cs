using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Cities")]
    public class CityDto : EntityData
    {
        public string CountryId { get; set; }

        public virtual CountryDto Country { get; set; }

        public string Name { get; set; }
    }
}