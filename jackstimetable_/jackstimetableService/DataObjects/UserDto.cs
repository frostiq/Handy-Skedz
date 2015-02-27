﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.DataObjects
{
    [Table("Users")]
    public class UserDto : EntityData
    {
        public string Username { get; set; }

        public string FullName { get; set; }
    }
}