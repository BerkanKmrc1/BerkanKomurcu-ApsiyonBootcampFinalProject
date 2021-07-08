using ApartmentManagement.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Infrastructure.Context
{
    public class ApartmentDbContext : IdentityDbContext<User>
    {
        public ApartmentDbContext(DbContextOptions<ApartmentDbContext> options) : base(options)
        {

        }

        public DbSet<Bloc> Blocs { get; set; }
        public DbSet<Dues> Dues { get; set; }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<HousingType> HousingTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> UserTable { get; set; }
 
    }
}
