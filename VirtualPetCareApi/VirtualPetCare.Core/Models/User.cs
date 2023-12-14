namespace VirtualPetCare.Core.Models;

public class User : Entity<long>
{
    public List<Pet> Pets { get; set; }
}
