using Laboratorul10.Domain;
using Laboratorul10.Repository;

namespace Laboratorul10.Service;

public class MeciService
{
    private IRepository<string, Meci> _repo;
    private IRepository<string,JucatorActiv> _repoJucatorActiv;
    private IRepository<string, Jucator> _repoJucator;

    public MeciService(IRepository<string, Meci> repo, IRepository<string,JucatorActiv> repoJucatorActiv, IRepository<string,Jucator> repoJucator)
    {
        this._repo = repo;
        this._repoJucatorActiv = repoJucatorActiv;
        this._repoJucator = repoJucator;
    }
    
    public List<Meci> FindAllMeciuri()
    {
        return _repo.FindAll().ToList();
    }

    public List<Meci> FindAllMeciuriPerioada(DateTime startDate, DateTime endDate)
    {
        return FindAllMeciuri()
            .Where(m => m.Date >= startDate && m.Date <= endDate)
            .OrderBy(m=>m.Date)
            .ToList();
    }
    
    public List<JucatorActiv> FindAllJucatoriActiviEchipaMeci(string IDechipa, string IDmeci)
    {
        var jucatoriActiviMeci = _repoJucatorActiv.FindAll().ToList()
            .Where(ja=>ja.IdMeci==IDmeci)
            .ToList();
        
        var jucatoriEchipa = _repoJucator.FindAll()
            .Where(j=> j.Echipa.Id == IDechipa)
            .Select(j=>j.Id)
            .ToHashSet();
        
        return jucatoriActiviMeci
            .Where(ja=>jucatoriEchipa.Contains(ja.IdJucator))
            .ToList();
    }
    
    public string scorMeci(string meciID)
    {
        Meci meci = FindAllMeciuri().Where(m=>m.Id == meciID).FirstOrDefault();
        
        var jucatoriActiviEchipa1 = FindAllJucatoriActiviEchipaMeci(meci.Echipa1.Id, meciID);
        int scorEchipa1 = jucatoriActiviEchipa1.Sum(ja => ja.NrPuncte);

        var jucatoriActiviEchipa2 = FindAllJucatoriActiviEchipaMeci(meci.Echipa2.Id, meciID);
        int scorEchipa2 = jucatoriActiviEchipa2.Sum(ja => ja.NrPuncte);
        
        return $"{meci.Echipa1.Nume} {scorEchipa1} - {scorEchipa2} {meci.Echipa2.Nume}";
    } 
}