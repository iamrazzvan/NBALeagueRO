using Laboratorul10.Domain;

namespace Laboratorul10.Repository;

public class MeciFile : InFileRepo<string, Meci>
{
    public MeciFile(string fileName) : base(fileName, EntityToFileMapping.CreateMeci)
    {
        
    }
}