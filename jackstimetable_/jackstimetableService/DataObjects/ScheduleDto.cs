using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Schedules")]
    public class ScheduleDto : EntityData
    {
        public StudyGroupDto StudyGroup { get; set; }
    }
}