namespace VirtualPetCare.Core.Interfaces.Services;

public interface IHealthConditionService<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task UpdateWithPatchAsync(T entity);
}
