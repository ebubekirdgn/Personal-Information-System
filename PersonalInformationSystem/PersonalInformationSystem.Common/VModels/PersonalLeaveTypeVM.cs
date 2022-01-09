namespace PersonalInformationSystem.Common.VModels
{
    public class PersonalLeaveTypeVM : BaseVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int DefaultDays { get; set; }

        public DateTime DateCreated { get; set; }

        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }
}