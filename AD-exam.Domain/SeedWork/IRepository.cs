using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace AD_exam.Domain.SeedWork
{
    public interface IRepository<T> where T: Entity
    {
        void Create(T e);                       
        void Delete(T e);       
        Task<List<T>> FindAllAsync();
    }
}
