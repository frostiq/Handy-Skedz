using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Locations")]
    public class LocationDto : EntityData
    {
        public string Country { get; set; }

        public string City { get; set; }
    }
}