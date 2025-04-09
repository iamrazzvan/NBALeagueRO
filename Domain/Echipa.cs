namespace Laboratorul10.Domain;

public class Echipa : Entity<string>
{
    public required string Nume { get; set; }

    public override string ToString()
    {
        return Id + " " + Nume;
    }
}