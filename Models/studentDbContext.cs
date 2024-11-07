using Microsoft.EntityFrameworkCore;

namespace ssemambo_jonthan_student_web_app.Models
{
    public class studentDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public studentDbContext(IConfiguration configuration) 
        {
           _configuration = configuration;
        }

        public DbSet<courseUnit> courseUnits {  get; set; }
        public DbSet<course> courses { get; set; }
        public DbSet<faculty> faculties { get; set; }
        public DbSet<house> houses { get; set; }
        public DbSet<student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString(name: "DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
