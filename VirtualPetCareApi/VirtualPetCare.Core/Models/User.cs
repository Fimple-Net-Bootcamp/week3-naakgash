namespace VirtualPetCare.Core.Models;

public class User : Entity<int>
{
    public List<Pet> Pets { get; set; }
}
