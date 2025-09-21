using Microsoft.EntityFrameworkCore;
using CarInsurance2.Models;

namespace CarInsurance2.Controllers.Data
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options)
        {

        }

        public DbSet<Insuree> Insuree { get; set; }

    }
}