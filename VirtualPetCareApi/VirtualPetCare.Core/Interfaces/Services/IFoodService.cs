using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Interfaces.Services;

public interface IFoodService<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<T> AddAsync(T entitiy);

}
