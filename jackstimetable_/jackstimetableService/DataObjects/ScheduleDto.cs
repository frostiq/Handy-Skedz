using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Schedules")]
    public class ScheduleDto : EntityData
    {
        public string StudyGroupId { get; set; }

        public virtual StudyGroupDto StudyGroup { get; set; }
    }
}