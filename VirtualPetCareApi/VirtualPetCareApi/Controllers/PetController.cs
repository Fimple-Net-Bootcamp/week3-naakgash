using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using VirtualPetCare.Core.Models;
using VirtualPetCare.Core.Repositories;
using VirtualPetCare.Repository.Repositories;

namespace VirtualPetCareApi.Controllers;

[ApiController]
[Route("/api/v1/pets")]
public class PetController : Controller
{
    private readonly IPetRepository _petRepository;
    public PetController(IPetRepository petRepository)
    {
        _petRepository = petRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Pet pet)
    {

        _petRepository.AddAsync(pet);

        return CreatedAtAction(nameof(GetById), new { id = pet.Id }, pet);

    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {

        var pet = _petRepository.GetByIdAsync(id);

        if (pet is null)
        {
            return NotFound();
        }

        return Ok(pet);
    }

    [HttpGet]
    public IActionResult GetAll()
    {

        var pets = _petRepository.GetAll();

        if (pets is null)
        {
            return NotFound();
        }

        return Ok(pets);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Pet pet)
    {

        var current = await _petRepository.UpdateWithPut(id, pet);

        if (current is null)
        {
            return NotFound();
        }

        return Ok();

    }

}
