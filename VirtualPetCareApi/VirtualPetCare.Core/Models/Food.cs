namespace VirtualPetCare.Core.Models;

public class Food : Entity<int>
{
    public List<Pet> Pets { get; set; }
}
