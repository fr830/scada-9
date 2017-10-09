using System.Data.Entity;

namespace DataConcentrator.Model.DatabaseManager
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AppDbContext>());
        }

        public virtual DbSet<AlarmDTO> Alarms { get; set; }
    }
}
