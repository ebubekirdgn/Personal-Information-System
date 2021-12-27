using System.ComponentModel.DataAnnotations;

namespace PersonelInformationSystem.Data.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id{ get; set; }
    }
}
