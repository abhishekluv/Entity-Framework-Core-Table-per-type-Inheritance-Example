namespace EFCoreTablePerTypeInheritance.Models
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Color { get; set; }
        public int Speed { get; set; }
    }
}
