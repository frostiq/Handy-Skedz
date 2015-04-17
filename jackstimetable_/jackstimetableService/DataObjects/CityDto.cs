using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Cities")]
    public class CityDto : EntityData
    {
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string Name { get; set; }

        public string CountryId { get; set; }

        public virtual CountryDto Country { get; set; }
    }
}