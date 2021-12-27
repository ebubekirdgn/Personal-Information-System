using Microsoft.AspNetCore.Identity;

namespace PersonelInformationSystem.Data.Models
{
    public class Personal : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxId { get; set; }
        public DateTime DateOfBirth{ get; set; }


    }
}
