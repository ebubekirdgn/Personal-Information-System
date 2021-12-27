using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelInformationSystem.Data.Models
{
    public class PersonalLeaveAllocation : BaseEntity
    {
        public int NumberOfDays{ get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }


        public string PersonalId{ get; set; } // string vermemizin sebebi tablo ile alakalı normalde yine int 
        
        [ForeignKey("PersonalId")]
        public Personal Personal { get; set; }

        public int PersonalLeaveTypelId { get; set; }

        [ForeignKey("PersonalLeaveTypelId")]
        public PersonalLeaveType PersonalLeaveType { get; set; }

    }
}
