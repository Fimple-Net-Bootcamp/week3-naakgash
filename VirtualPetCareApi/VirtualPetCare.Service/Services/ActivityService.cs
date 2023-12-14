using VirtualPetCare.Core.Interfaces.Services;

namespace VirtualPetCare.Service.Services;

public class ActivityService<T> : IActivityService<T> where T : class
{
    public Task<T> AddAsync(T entitiy)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
