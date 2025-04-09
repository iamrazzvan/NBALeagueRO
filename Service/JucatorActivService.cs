using Laboratorul10.Domain;
using Laboratorul10.Repository;

namespace Laboratorul10.Service;

public class JucatorActivService
{
    private IRepository<string, JucatorActiv> _repo;
    private IRepository<string, Jucator> _jucatorRepo;

    public JucatorActivService(IRepository<string, JucatorActiv> repo, IRepository<string, Jucator> jucatorRepo)
    {
        this._repo = repo;
        this._jucatorRepo = jucatorRepo;
    }
    
    public List<JucatorActiv> FindAllJucatoriActivi()
    {
        return _repo.FindAll().ToList();
    }

    public List<JucatorActiv> FindAllJucatoriActiviEchipaMeci(string IDechipa, string IDmeci)
    {
        var jucatoriActiviMeci = FindAllJucatoriActivi()
            .Where(ja=>ja.IdMeci==IDmeci)
            .ToList();
        
        var jucatoriEchipa = _jucatorRepo.FindAll()
            .Where(j=> j.Echipa.Id == IDechipa)
            .Select(j=>j.Id)
            .ToHashSet();

        return jucatoriActiviMeci
            .Where(ja => jucatoriEchipa.Contains(ja.IdJucator))
            .ToList();
    }
}