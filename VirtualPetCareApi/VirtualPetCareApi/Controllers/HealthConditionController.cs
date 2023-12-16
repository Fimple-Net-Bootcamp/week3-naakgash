using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.Core.Repositories;
using VirtualPetCare.Repository.Repositories;

namespace VirtualPetCareApi.Controllers;

[Route("api/v1/healthconditions")]
[ApiController]
public class HealthConditionController : Controller
{
    private readonly IHealthConditionRepository _healthConditionRepository;
    public HealthConditionController(IHealthConditionRepository healthConditionRepository)
    {
        _healthConditionRepository = healthConditionRepository;
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {

        var cond = _healthConditionRepository.GetByIdAsync(id);

        if (cond is null)
        {
            return NotFound();
        }

        return Ok(cond);
    }
}
