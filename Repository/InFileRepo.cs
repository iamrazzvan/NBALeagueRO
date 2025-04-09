using Laboratorul10.Domain;

namespace Laboratorul10.Repository;

public delegate TE CreateEntity<TE>(string line);

public abstract class InFileRepo<TId, TE> : InMemoryRepository<TId, TE> where TE : Entity<TId>
{
    protected string FileName;
    protected CreateEntity<TE> CreateEntity;

    public InFileRepo(string fileName, CreateEntity<TE> createEntity) : base()
    {
        this.FileName = fileName;
        this.CreateEntity = createEntity;
        if (createEntity != null)
            LoadFromFile();
    }

    protected virtual void LoadFromFile()
    {
        List<TE> list = DataReader.ReadData(FileName, CreateEntity);
        list.ForEach(x => entities[x.Id] = x);
    }
}