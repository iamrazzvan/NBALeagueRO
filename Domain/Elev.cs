namespace Laboratorul10.Domain;

public class Elev : Entity<string>
{
    public required string Nume{get; set;}
    
    public required string Scoala{get; set;}
    
    public override string ToString()
    {
        return Id +" "+ Nume+ " " + Scoala;
    }
}