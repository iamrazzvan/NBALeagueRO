using Laboratorul10.Domain;

namespace Laboratorul10.Repository;

public class ElevFile : InFileRepo<string, Elev>
{
    public ElevFile(string fileName) : base(fileName, EntityToFileMapping.CreateElev)
    {
        
    }
}