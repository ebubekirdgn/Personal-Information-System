using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelInformationSystem.Data.DataContext
{
    public class PersonelInformationContext :IdentityDbContext
    {
        public PersonelInformationContext(DbContextOptions options) :base(options)
        {

        }
    }
}
