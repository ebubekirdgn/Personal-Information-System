using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonelInformationSystem.Data.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
