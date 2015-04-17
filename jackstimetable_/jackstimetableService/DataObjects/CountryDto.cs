using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Countries")]
    public class CountryDto : EntityData
    {
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}