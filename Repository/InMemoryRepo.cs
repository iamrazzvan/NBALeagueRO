using Laboratorul10.Domain;

namespace Laboratorul10.Repository;

public class InMemoryRepository<TId, TE> : IRepository<TId, TE> where TE : Entity<TId>
{
    protected IDictionary<TId, TE> entities = new Dictionary<TId, TE>();

    public IEnumerable<TE> FindAll()
    {
        return entities.Values.ToList<TE>();
    }
}