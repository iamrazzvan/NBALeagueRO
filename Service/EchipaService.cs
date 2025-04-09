using Laboratorul10.Domain;
using Laboratorul10.Repository;

namespace Laboratorul10.Service;

public class EchipaService
{
    private IRepository<string, Echipa> _repo;

    public EchipaService(IRepository<string, Echipa> repo)
    {
        this._repo = repo;
    }
    
    public List<Echipa> FindAllEchipe()
    {
        return _repo.FindAll().ToList();
    }
}