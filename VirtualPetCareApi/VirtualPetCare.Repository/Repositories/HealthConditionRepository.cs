using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;

namespace VirtualPetCare.Repository.Repositories;

public class HealthConditionRepository : IHealthConditionRepository
{
    private readonly PetDbContext _petDbContext;
    public HealthConditionRepository(PetDbContext petDbContext)
    {
        _petDbContext = petDbContext;
    }
    public async Task<HealthCondition> GetByIdAsync(int id)
    {
        return _petDbContext.HealthConditions.Where(x => x.Id == id).FirstOrDefault();
    }

    public void UpdateWithPatch(int id, HealthCondition healthCondition)
    {
        throw new NotImplementedException();
    }
}
