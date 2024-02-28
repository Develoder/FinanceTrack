using Microsoft.EntityFrameworkCore;
using FinanceTrack.Properties;

namespace FinanceTrack.DataLayer
{
    public class EntitiesContext : EntitiesBaseContext
    {
        public EntitiesContext()
        {
        }

        public EntitiesContext(DbContextOptions<EntitiesBaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Settings.Default.PgConnectionString);
        }
    }
}
