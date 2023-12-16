using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;

namespace VirtualPetCare.Repository.Repositories;

public class FoodRepository : IFoodRepository
{
    private readonly PetDbContext _petDbContext;
    public FoodRepository(PetDbContext petDbContext)
    {
        _petDbContext = petDbContext;
    }
    public Task FeedAsync(Food food)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Food> GetAll()
    {
        return _petDbContext.Foods;
    }
}
