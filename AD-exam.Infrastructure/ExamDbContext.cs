using Microsoft.EntityFrameworkCore;

namespace AD_exam.Infrastructure
{
    public class ExamDbContext : DbContext
    {
                
        public ExamDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {           
            options.UseSqlite("Data Source=exam.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
        }
    }
}
