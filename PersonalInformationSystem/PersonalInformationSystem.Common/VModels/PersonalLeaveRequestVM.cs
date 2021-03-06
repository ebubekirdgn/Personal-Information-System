using PersonalInformationSystem.Common.ConstantsModels;
using PersonalInformationSystem.Common.Extension;

namespace PersonalInformationSystem.Common.VModels
{
    public class PersonalLeaveRequestVM : BaseVM
    {
        public string RequestPersonalName { get; set; }
        public string? RequestingPersonalId { get; set; }
        public PersonalVM? RequestingPersonal { get; set; }

        //TODO:Onaylayan Kullanıcı Bilgileri
        public string? ApprovedPersonalId { get; set; }

        public PersonalVM? ApprovedPersonal { get; set; }

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

        // public EnumPersonalLeaveRequestStatus ApprovedStatus { get { return (EnumPersonalLeaveRequestStatus)Approved; }}
        //public EnumPersonalLeaveRequestStatus ApprovedStatus { get; set; }
        // public string ApprovedText { get; set; }
        private EnumPersonalLeaveRequestStatus _approvedStatusValue = 0;

        public int? Approved { get; set; }

        public EnumPersonalLeaveRequestStatus ApprovedStatus
        {
            get => _approvedStatusValue == 0 || Approved == null ? EnumPersonalLeaveRequestStatus.Send_Approved : (EnumPersonalLeaveRequestStatus)Approved;
            set => _approvedStatusValue = value;
        }

        private string _approvedText;

        public string ApprovedText
        {
            get => _approvedText ?? EnumExtension<EnumPersonalLeaveRequestStatus>.GetDisplayValue(ApprovedStatus);
            set => _approvedText = value;
        }

        public bool Cancelled { get; set; }
    }
}