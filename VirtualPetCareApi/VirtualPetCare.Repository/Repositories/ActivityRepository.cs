﻿using VirtualPetCare.Core.Interfaces.Repositories;

namespace VirtualPetCare.Repository.Repositories;

public class ActivityRepository<T> : IActivityRepository<T> where T : class
{
    public Task AddAsync(T entitiy)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}