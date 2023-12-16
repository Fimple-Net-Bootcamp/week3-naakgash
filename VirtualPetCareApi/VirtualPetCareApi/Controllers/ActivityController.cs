using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;

namespace VirtualPetCareApi.Controllers;

[ApiController]
[Route("/api/v1/activities")]
public class ActivityController : Controller
{
    private readonly IActivityRepository _activityRepository;
    public ActivityController(IActivityRepository activityRepository)
    {
        _activityRepository = activityRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Activity activity)
    {

        _activityRepository.AddAsync(activity);

        return CreatedAtAction(nameof(GetById), new { id = activity.Id }, activity);

    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {

        var activity = _activityRepository.GetByIdAsync(id);

        if (activity is null)
        {
            return NotFound();
        }

        return Ok(activity);
    }
}