using AD_exam.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AD_exam.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private ExamDbContext _dbContext;


        public UnitOfWork()
        {
            _dbContext = new ExamDbContext();
            _dbContext.Database.Migrate();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }

}
