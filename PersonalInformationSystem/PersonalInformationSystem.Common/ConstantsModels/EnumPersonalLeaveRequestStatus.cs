namespace PersonalInformationSystem.Common.ConstantsModels
{
    public enum EnumPersonalLeaveRequestStatus
    {
        [Display(Name = "Onaya Gönderildi")]
        Send_Approved =1,

        [Display(Name = "Onaylandı")]
        Approved =2,

        [Display(Name = "Reddedildi")]
        Rejected =3
    }
}
