using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.Repositories;

public interface IUserRepository
{
    Task<User> AddAsync(User user);
    Task<User> GetByIdAsync(int id);
}
