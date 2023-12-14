using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Interfaces.Repositories;

public interface IPetRepository<T> where T : class
{
    Task AddAsync(T entity);
    IQueryable<T> GetAll();
    Task<T> GetByIdAsync(int id);
    void UpdateWithPut(int id, T entity);
}
