namespace VirtualPetCare.Core.Models;

public abstract class Entity<T>
{
    public T Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
