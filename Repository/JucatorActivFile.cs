using Laboratorul10.Domain;

namespace Laboratorul10.Repository;

public class JucatorActivFile : InFileRepo<string, JucatorActiv>
{
    public JucatorActivFile(string fileName) : base(fileName, EntityToFileMapping.CreateJucatorActiv)
    {
        
    }
}