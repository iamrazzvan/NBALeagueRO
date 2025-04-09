using Laboratorul10.Domain;
using Laboratorul10.Repository;

namespace Laboratorul10.Service;

public class ElevService
{
    private IRepository<string, Elev> _repo;

    public ElevService(IRepository<string, Elev> repo)
    {
        this._repo = repo;
    }

    public List<Elev> FindAllElevi()
    {
        return _repo.FindAll().ToList();
    }
}