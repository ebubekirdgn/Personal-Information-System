using PersonalInformationSystem.Common.ConstantsModels;

namespace PersonalInformationSystem.Common.VModels
{
    public class PersonalLeaveRequestVM : BaseVM
    {
        public string RequestingPersonalId { get; set; }
        public PersonalVM RequestingPersonal { get; set; }

        //TODO:Onaylayan Kullanıcı Bilgileri
        public string ApprovedPersonalId { get; set; }

        public PersonalVM ApprovedPersonal { get; set; }

        [Required]
        public int? PersonalLeaveTypeId { get; set; }

        public string LeaveTypeText { get; set; }
        public PersonalLeaveTypeVM PersonalLeaveType { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public DateTime DateRequested { get; set; }

        [Display(Name = "Talep Açıklama")]
        [MaxLength(300, ErrorMessage = "300 Karakterden Fazla Değer Girilemez")]
        public string RequestComments { get; set; }

        public EnumPersonalLeaveRequestStatus ApprovedStatus { get; set; }
        public string ApprovedText { get; set; }
        public bool Cancelled { get; set; }
    }
}