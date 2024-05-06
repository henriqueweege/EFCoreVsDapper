using EFCoreVsDapper.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreVsDapper.EFCore.Context
{
    public class EFContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(Settings.ConnectionString);
        }
        public virtual DbSet<SchoolModel> Schools { get; set; }
        public virtual DbSet<StudentModel> Students { get; set; }
        public virtual DbSet<TeacherModel> Teachers { get; set; }
    }
}
