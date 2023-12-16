using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.Repositories;

public interface IPetRepository
{
    Task<Pet> AddAsync(Pet pet);
    IQueryable<Pet> GetAll();
    Task<Pet> GetByIdAsync(int id);
    Task<Pet> UpdateWithPut(int id, Pet pet);
}
