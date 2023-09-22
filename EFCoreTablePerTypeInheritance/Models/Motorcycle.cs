namespace EFCoreTablePerTypeInheritance.Models
{
    public class Motorcycle : Vehicle
    {
        public EnginePower EnginePower { get; set; }
    }
    public enum EnginePower
    {
        CC350 = 1,
        CC500 = 2
    }
}
