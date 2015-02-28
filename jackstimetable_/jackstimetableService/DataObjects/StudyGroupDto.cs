using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("StudyGroups")]
    public class StudyGroupDto : EntityData
    {
        public string Name { get; set; }

        public SchoolDto School { get; set; }

        public virtual ICollection<UserDto> Users { get; set; }
    }
}