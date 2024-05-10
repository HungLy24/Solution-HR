using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contacts
{
    public interface IGenericRepository< T> where T : class
    {
        Task<IReadOnlyCollection<T>> GetAsync();
        Task<T> GetByAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);   
    }
}
