namespace Laboratorul10.Domain;

public class Jucator : Elev
{
    public required Echipa Echipa { get; set; }
    
    public override string ToString()
    {
        return base.ToString() + " " + Echipa;
    }
}