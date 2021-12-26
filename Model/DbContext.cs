using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminJwtToken.Model
{
    public class DbContext
    {
        public class APIDbContext : IdentityDbContext<ApplicationUser>
        {
            public readonly IHttpContextAccessor httpContextAccessor;

            public APIDbContext(DbContextOptions<APIDbContext> options, IHttpContextAccessor httpContextAccessor)
                : base(options)
            {
                this.httpContextAccessor = httpContextAccessor;
            }

            public DbSet<ApplicationUserTokens> ApplicationUserTokens { get; set; }
            public DbSet<Panel> Panel { get; set; }


            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);

                builder.Entity<Panel>().ToTable("Panel");
                builder.Entity<Panel>().HasIndex(x => x.Name).IsUnique();
                
            }
        }
    }
}
