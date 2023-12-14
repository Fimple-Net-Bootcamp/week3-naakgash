using VirtualPetCare.Core.Interfaces.Repositories;

namespace VirtualPetCare.Repository.Repositories;

internal class HealthConditionRepository<T> : IHealthConditionRepository<T> where T : class
{
    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateWithPatch(int id, T entity)
    {
        throw new NotImplementedException();
    }
}
