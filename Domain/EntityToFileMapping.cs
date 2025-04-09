namespace Laboratorul10.Domain;

public class EntityToFileMapping
{
    public static Echipa CreateEchipa(string line)
    {
        string[] fields = line.Split(',');
        var echipa = new Echipa()
        {
            Id = fields[0],
            Nume = fields[1],
        };
        return echipa;
    }
    
    public static JucatorActiv CreateJucatorActiv(string line)
    {
        string[] fields = line.Split(',');
        var jucatorActiv = new JucatorActiv()
        {
            IdJucator = fields[0],
            IdMeci = fields[1],
            Id = fields[0]+fields[1],
            NrPuncte = int.Parse(fields[2]),
            Tip = (Tip)Enum.Parse(typeof(Tip), fields[3])
        };
        return jucatorActiv;
    }

    public static Elev CreateElev(string line)
    {
        string[] fields = line.Split(',');
        var elev = new Elev()
        {
            Id = fields[0],
            Nume = fields[1],
            Scoala =  fields[2]
        };
        return elev;
    }
    
    public static Jucator CreateJucator(string line)
    {
        string[] fields = line.Split(',');
        var jucator = new Jucator()
        {
            Id = fields[0],
            Nume = fields[1],
            Scoala = fields[2],
            Echipa = CreateEchipa(fields[3]+","+fields[4]),
        };
        return jucator;
    }

    public static Meci CreateMeci(string line)
    {
        string[] fields = line.Split(',');
        var meci = new Meci()
        {
            Id = fields[0],
            Echipa1 = CreateEchipa(fields[1] + "," + fields[2]),
            Echipa2 = CreateEchipa(fields[3] + "," + fields[4]),
            Date = DateTime.ParseExact(fields[5], "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        };
        return meci;
    }
}