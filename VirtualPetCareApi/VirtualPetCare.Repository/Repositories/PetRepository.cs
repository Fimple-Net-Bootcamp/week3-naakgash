using VirtualPetCare.Core.Interfaces.Repositories;

namespace VirtualPetCare.Repository.Repositories;

public class PetRepository<T> : IPetRepository<T> where T : class
{
    public Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateWithPut(int id, T entity)
    {
        throw new NotImplementedException();
    }
}
