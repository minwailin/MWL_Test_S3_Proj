using Microsoft.EntityFrameworkCore;
using MWL_Test_S3_Proj.Model;

namespace MWL_Test_S3_Proj.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<DeviceData> deviceDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
