using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;

namespace VirtualPetCare.Repository.Repositories;

public class ActivityRepository : IActivityRepository
{
    private readonly PetDbContext _petDbContext;
    public ActivityRepository(PetDbContext petDbContext)
    {
        _petDbContext = petDbContext;
    }
    public async Task<Activity> AddAsync(Activity activity)
    {
        _petDbContext.Activities.Add(activity);
        await _petDbContext.SaveChangesAsync();
        return activity;
    }

    public async Task<Activity> GetByIdAsync(int id)
    {
        return _petDbContext.Activities.Where(x => x.Id == id).FirstOrDefault();
    }
}
