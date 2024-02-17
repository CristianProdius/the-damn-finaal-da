using AD_exam.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AD_exam.Infrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly ExamDbContext _dbContext;
   
        public Repository(ExamDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Create(T e)
        {
            _dbContext.Add(e);
        }
        public void Delete(T e)
        {
            _dbContext.Remove(e);
        }

        public virtual async Task<List<T>> FindAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

       
    }
}
