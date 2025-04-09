using Laboratorul10.Domain;

namespace Laboratorul10.Repository;

public class EchipaFile : InFileRepo<string, Echipa>
{
    public EchipaFile(string fileName) : base(fileName, EntityToFileMapping.CreateEchipa)
    {
        
    }
}