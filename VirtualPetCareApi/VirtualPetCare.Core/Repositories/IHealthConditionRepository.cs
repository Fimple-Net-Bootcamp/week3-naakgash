using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.Repositories;

public interface IHealthConditionRepository
{
    Task<HealthCondition> GetByIdAsync(int id);
    void UpdateWithPatch(int id, HealthCondition healthCondition);
}
