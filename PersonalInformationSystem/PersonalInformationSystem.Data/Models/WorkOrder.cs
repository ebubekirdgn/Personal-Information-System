namespace PersonalInformationSystem.DataAccess.Models
{
    public class WorkOrder : BaseEntity
    {
        public DateTime CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [MaxLength(750)]
        public string WorkOrderDescription { get; set; }

        public int WorkOrderStatus { get; set; }

        public double WorkOrderPoint { get; set; }
        public string PhotoPath { get; set; }

        [MaxLength(35)]
        public string WorkOrderNumber { get; set; }

        public string AssignPersonalId { get; set; }

        [ForeignKey("AssignPersonalId")]
        public Personal AssignPersonal { get; set; }
    }
}