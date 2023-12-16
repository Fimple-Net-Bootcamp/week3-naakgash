using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;

namespace VirtualPetCareApi.Controllers;

[ApiController]
[Route("/api/v1/users")]
public class UserController : Controller
{
    private readonly IUserRepository _userRepository;
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Create(User user)
    {

        _userRepository.AddAsync(user);

        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);

    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {

        var user = _userRepository.GetByIdAsync(id);

        if (user is null)
        {
            return NotFound();
        }

        return Ok(user);
    }
}