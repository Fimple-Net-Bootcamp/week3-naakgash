using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Interfaces.Repositories;

namespace VirtualPetCare.Repository.Repositories;

public class FoodRepository<T> : IFoodRepository<T> where T : class
{
    public Task FeedAsync(T entitiy)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }
}
