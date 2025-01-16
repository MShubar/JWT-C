using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyJWSApp.Api.Models;

namespace MyJWSApp.Api.Context
{
    public class AuthDemoDbContext : IdentityDbContext 
    {
        public AuthDemoDbContext(DbContextOptions<AuthDemoDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
