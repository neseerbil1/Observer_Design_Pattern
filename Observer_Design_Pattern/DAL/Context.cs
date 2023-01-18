using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Observer_Design_Pattern.DAL.Entities;

namespace Observer_Design_Pattern.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-T0I7RRL;initial catalog=ObserverDb;integrated security=true;");
        }
        public DbSet<Discount> Discounts { get; set; }
    }
}
