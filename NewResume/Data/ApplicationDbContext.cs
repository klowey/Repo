using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewResume.Models;
using NewResume.Models.EmployerJobViewModel;

namespace NewResume.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
              
          
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Skill> Skill { get; set; }

        public DbSet<ContactInfo> ContactInfo { get; set; }

        public DbSet<Job> Job { get; set; }

        public DbSet<Employer> Employer { get; set; }

        public DbSet<Education> Education { get; set; }

        public DbSet<Reference> Reference { get; set; }

        public DbSet<EmployerJobViewModel> EmployerJobViewModel { get; set; }

        public DbSet<JobDuty> JobDuty { get; set; }

       
       

    }
}
