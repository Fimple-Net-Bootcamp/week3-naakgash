using System;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.Repositories;

public interface IActivityRepository
{
    Task<Activity> AddAsync(Activity activity);
    Task<Activity> GetByIdAsync(int id);

}
