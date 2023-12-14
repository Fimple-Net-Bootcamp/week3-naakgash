using VirtualPetCare.Core.Interfaces.Services;

namespace VirtualPetCare.Service.Services;

public class PetService<T> : IPetService<T> where T : class
{
    public Task<T> AddAsync(T entitiy)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateWithPutAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
