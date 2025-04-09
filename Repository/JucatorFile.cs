using Laboratorul10.Domain;

namespace Laboratorul10.Repository;

public class JucatorFile : InFileRepo<string, Jucator>
{
    public JucatorFile(string fileName) : base(fileName, EntityToFileMapping.CreateJucator)
    {
        
    }
}