using PersonalInformationSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationSystem.Common.VModels
{
    public class PersonalLeaveAllocationsVM
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }

        public string EmployeeId { get; set; }
        public Personal EmployeeVm { get; set; }
        public int EmployeeLeaveTypeId { get; set; }
        public PersonalLeaveTypeVM EmployeeLeaveTypeVm { get; set; }
    }
}
