using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Needed for SecurityContext.
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// Needed for SecurityContext.
using Microsoft.EntityFrameworkCore;


namespace BlindDating.Models
{
    // SecurityContext is inheriting from IdentityDbContext.
	public class SecurityContext : IdentityDbContext
	{
        public SecurityContext()
        {
        }

        public SecurityContext(DbContextOptions<SecurityContext> options)
            : base(options)
        {
        }

        // Standard override OnConfiguring method referencing BlindDating database.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BlindDating;Trusted_Connection=True");
            }
        }


    }
}
