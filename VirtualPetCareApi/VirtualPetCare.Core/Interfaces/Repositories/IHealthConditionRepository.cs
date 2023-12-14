using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Interfaces.Repositories;

public interface IHealthConditionRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    void UpdateWithPatch(int id, T entity);
}
