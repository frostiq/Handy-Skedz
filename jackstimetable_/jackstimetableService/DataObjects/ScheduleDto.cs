using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Schedules")]
    public class ScheduleDto : EntityData
    {
        public StudyGroupDto StudyGroup { get; set; }
    }
}