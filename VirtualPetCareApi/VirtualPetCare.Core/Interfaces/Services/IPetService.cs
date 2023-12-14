using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Interfaces.Services;

public interface IPetService<T> where T : class
{
    Task<T> AddAsync(T entitiy);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task UpdateWithPutAsync(T entity);
}
