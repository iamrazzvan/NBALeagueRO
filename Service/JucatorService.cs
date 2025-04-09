using Laboratorul10.Domain;
using Laboratorul10.Repository;

namespace Laboratorul10.Service;

public class JucatorService
{
    private IRepository<string, Jucator> _repo;

    public JucatorService(IRepository<string, Jucator> repo)
    {
        this._repo = repo;
    }
    
    public List<Jucator> FindAllJucatori()
    {
        return _repo.FindAll().ToList();
    }

    public List<Jucator> FindAllEchipa(string idEchipa)
    {
        List<Jucator> jucatori = FindAllJucatori();
        
        var result = from j in jucatori
            where j.Echipa.Id == idEchipa
            select j;
        return result.ToList();
    }
}