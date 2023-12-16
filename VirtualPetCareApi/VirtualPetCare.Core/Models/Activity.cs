namespace VirtualPetCare.Core.Models;

public class Activity : Entity<int>
{
    public List<Pet> Pets { get; set; }
}
