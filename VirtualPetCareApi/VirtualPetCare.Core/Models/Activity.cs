namespace VirtualPetCare.Core.Models;

public class Activity : Entity<byte>
{
    public List<Pet> Pets { get; set; }
}
