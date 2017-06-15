using Microsoft.EntityFrameworkCore;


namespace GoogleLedApp.Models
{
    public class GoogleLedAppContext : DbContext
    {
        public GoogleLedAppContext(DbContextOptions<GoogleLedAppContext> options) : base(options)
        {

        }

        public DbSet<color> colors { get; set; }
        public DbSet<status> statuses { get; set; }
    }   
}
