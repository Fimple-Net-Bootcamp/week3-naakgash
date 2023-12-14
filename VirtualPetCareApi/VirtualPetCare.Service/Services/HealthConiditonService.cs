using VirtualPetCare.Core.Interfaces.Services;

namespace VirtualPetCare.Service.Services;

public class HealthConiditonService<T> : IHealthConditionService<T> where T : class
{
    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateWithPatchAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
