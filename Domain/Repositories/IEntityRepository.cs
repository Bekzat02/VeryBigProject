using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IEntityRepository<T> where T : class
    {
     /*   void Create(User user);*/
        /*Task<IEnumerable<User>> GetUsers();
        Task<bool> AddStudent(User user);*/
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
