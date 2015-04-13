using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Countries")]
    public class CountryDto : EntityData
    {
        public string Name { get; set; }
    }
}