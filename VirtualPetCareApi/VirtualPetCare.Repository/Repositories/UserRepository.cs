using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;

namespace VirtualPetCare.Repository.Repositories;

public class UserRepository : IUserRepository
{
    private readonly PetDbContext _petDbContext;
    public UserRepository(PetDbContext petDbContext)
    {

        _petDbContext = petDbContext;

    }
    public async Task<User> AddAsync(User user)
    {
        _petDbContext.Users.Add(user);
        await _petDbContext.SaveChangesAsync();
        return user;
    }

    public async Task<User> GetByIdAsync(int id)
    {
        return _petDbContext.Users.Where(x => x.Id == id).FirstOrDefault();
    }
}
