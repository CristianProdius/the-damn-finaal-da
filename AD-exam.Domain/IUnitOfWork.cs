using System;
using System.Threading.Tasks;

namespace AD_exam.Domain
{
    public interface IUnitOfWork: IDisposable
    {
        Task SaveAsync();
    }
}
