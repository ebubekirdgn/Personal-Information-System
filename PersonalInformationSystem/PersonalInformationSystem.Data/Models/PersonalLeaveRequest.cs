namespace PersonalInformationSystem.Data.Models
{
    public class PersonalLeaveRequest : BaseEntity
    {
        //------------------------------------------------------------//
        //TODO:Talepte Bulunan Kullanıcı Bilgileri
        public string RequestingPersonalId { get; set; }

        [ForeignKey("RequestingPersonalId")]
        public Personal RequestingPersonal { get; set; }

        //TODO:Onaylayan Kullanıcı Bilgileri
        public string ApprovedPersonalId { get; set; } // string vermemizin sebebi tablo ile alakalı normalde yine int

        [ForeignKey("ApprovedPersonalId")]
        public Personal ApprovedPersonal { get; set; }

        public int PersonalLeaveTypeId { get; set; }

        [ForeignKey("PersonalLeaveTypeId")]
        public PersonalLeaveType PersonalLeaveType { get; set; }

        //------------------------------------------------------------//
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}