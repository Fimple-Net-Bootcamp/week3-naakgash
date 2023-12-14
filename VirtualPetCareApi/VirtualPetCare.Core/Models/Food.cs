namespace VirtualPetCare.Core.Models;

public class Food : Entity<byte>
{
    public List<Pet> Pets { get; set; }
}
