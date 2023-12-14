using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Interfaces.Repositories;

public interface IFoodRepository<T> where T : class
{
    IQueryable<T> GetAll();
    Task FeedAsync(T entitiy);
}
