using System.ComponentModel.DataAnnotations.Schema;

namespace PersonelInformationSystem.Data.Models
{
    public class PersonalLeaveRequest : BaseEntity
    {

        // TALEPTE BULUNAN KULLANICI BİLGİLERİ
        public string RequestingPersonalId { get; set; }

        [ForeignKey("RequestingPersonalId")]
        public Personal RequestingPersonal { get; set; }


        // ONAYLAYAN KULLANICI BİLGİLERİ
        public string ApprovedPersonalId { get; set; }

        [ForeignKey("ApprovedPersonalId")]
        public Personal ApprovedPersonal{ get; set; }



        public int PersonalLeaveTypeId { get; set; }

        [ForeignKey("PersonalLeaveTypeId")]
        public PersonalLeaveType PersonalLeaveType { get; set; }

        //--------------------------------------------------------------

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequest { get; set; }
        public string RequestComment { get; set; }
        public bool? IsApproved { get; set; }
        public bool Cancelled { get; set; }

    }
}
