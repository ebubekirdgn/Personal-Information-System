﻿namespace PersonelInformationSystem.Data.Models
{
    public class PersonalLeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
