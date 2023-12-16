using System.Reflection.PortableExecutable;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;

namespace VirtualPetCare.Repository.Repositories;

public class PetRepository : IPetRepository
{
    private PetDbContext _petDbContext;
    public PetRepository(PetDbContext petDbContext)
    {
        _petDbContext = petDbContext;
    }
    public async Task<Pet> AddAsync(Pet pet)
    {
        _petDbContext.Pets.Add(pet);
        await _petDbContext.SaveChangesAsync();
        return pet;
    }

    public IQueryable<Pet> GetAll()
    {
        return _petDbContext.Pets;
    }

    public async Task<Pet> GetByIdAsync(int id)
    {
        return _petDbContext.Pets.Where(x => x.Id == id).FirstOrDefault();
    }
    public async Task<Pet> UpdateWithPut(int id, Pet pet)
    {
        var current = _petDbContext.Pets.Where(x => x.Id == id).FirstOrDefault();

        if (current is null)
        {
            return null;
        }

        current.Name = pet.Name;

        await _petDbContext.SaveChangesAsync();

        return current;
    }

}
