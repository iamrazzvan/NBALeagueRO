using Laboratorul10.Domain;

namespace Laboratorul10.Repository;

public interface IRepository<TId, TE> where TE : Entity<TId>
{
    IEnumerable<TE> FindAll();
}