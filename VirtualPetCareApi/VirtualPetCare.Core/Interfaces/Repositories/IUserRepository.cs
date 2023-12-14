using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Interfaces.Repositories;

public interface IUserRepository<T> where T : class
{
    Task AddAsync(T entitiy);
    Task<T> GetByIdAsync(int id);
}
