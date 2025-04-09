using System.Globalization;

namespace Laboratorul10.Domain;

public class Meci : Entity<string>
{
    public required Echipa Echipa1{get; set; }
    public required Echipa Echipa2{get; set; }
    
    public DateTime Date {get; set; }

    public override string ToString()
    {
        return $"{Id} {Echipa1} {Echipa2} {Date.ToString("d/M/yyyy",CultureInfo.InvariantCulture)}";
    }
}