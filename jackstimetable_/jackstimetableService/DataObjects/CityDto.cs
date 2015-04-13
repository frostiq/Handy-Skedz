using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Cities")]
    public class CityDto : EntityData
    {
        public CountryDto Country { get; set; }

        public string Name { get; set; }
    }
}