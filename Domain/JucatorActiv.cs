namespace Laboratorul10.Domain;

public enum Tip
{
    Rezerva,
    Participant
}


public class JucatorActiv : Entity<string>
{
    public required string IdJucator { get; set; }
    
    public required string IdMeci { get; set; }
    public int NrPuncte {get; set; }
    public Tip Tip {get; set; }

    public override string ToString()
    {
        return Id + " " + IdJucator + " " + IdMeci + " " + NrPuncte + " " + Tip;
    }
    
}