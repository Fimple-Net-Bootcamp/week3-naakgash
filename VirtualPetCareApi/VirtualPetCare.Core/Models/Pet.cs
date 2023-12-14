using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.Core.Models;

public class Pet : Entity<long>
{
    public byte Age { get; set; }
    public User User { get; set; }
    public HealthCondition HealthCondition { get; set; }
    public List<Activity> Activities { get; set; }
    public List<Food> Foods { get; set; }
}
