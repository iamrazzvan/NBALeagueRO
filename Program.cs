using Laboratorul10.Domain;
using Laboratorul10.Repository;
using Laboratorul10.Service;
using Laboratorul10.UI;

public class Program
{
    private static void test_files()
    {
        var filename = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\echipe.txt";
        IRepository<string, Echipa> repo1 = new EchipaFile(filename);
        var service1 = new EchipaService(repo1);
        List<Echipa> echipe = service1.FindAllEchipe(); 
        echipe.ForEach(item=>Console.WriteLine(item));
        
        var filename2 = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\elevi.txt";
        IRepository<string, Elev> repo2 = new ElevFile(filename2);
        var service2 = new ElevService(repo2);
        List<Elev> elevi = service2.FindAllElevi();
        elevi.ForEach(item => Console.WriteLine(item));

        var filename3 = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Datajucatori.txt";
        IRepository<string, Jucator> repo3 = new JucatorFile(filename3);
        var service3 = new JucatorService(repo3);
        List<Jucator> jucatori = service3.FindAllJucatori();
        jucatori.ForEach(item => Console.WriteLine(item));

        var filename4 = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\jucatoriActivi.txt";
        IRepository<string, JucatorActiv> repo4 = new JucatorActivFile(filename4);
        var service4 = new JucatorActivService(repo4,repo3);
        List<JucatorActiv> jucatoriActivi = service4.FindAllJucatoriActivi();
        jucatoriActivi.ForEach(item => Console.WriteLine(item));

        var filename5 = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\meciuri.txt";
        IRepository<string, Meci> repo5 = new MeciFile(filename5);
        var service5 = new MeciService(repo5,repo4,repo3);
        List<Meci> meciuri = service5.FindAllMeciuri();
        meciuri.ForEach(item => Console.WriteLine(item));
        
        Console.WriteLine("----------------");
        var l =service3.FindAllEchipa("a1");
        l.ForEach(item => Console.WriteLine(item));

    }
    
    public static void Main(string[] args)
    {
        //test_files();
        var filename = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\echipe.txt";
        var filename2 = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\elevi.txt"; 
        var filename3 = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\jucatori.txt"; 
        var filename4 = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\jucatoriActivi.txt"; 
        var filename5 = "C:\\Users\\Razva\\OneDrive\\CS-UBB_CJ\\Anul_II\\1st semester\\MAP\\Laborator\\Laboratorul10\\Data\\meciuri.txt";
        
        IRepository<string, Echipa> repo1 = new EchipaFile(filename);
        IRepository<string, Elev> repo2 = new ElevFile(filename2);
        IRepository<string, Jucator> repo3 = new JucatorFile(filename3);
        IRepository<string, JucatorActiv> repo4 = new JucatorActivFile(filename4); 
        IRepository<string, Meci> repo5 = new MeciFile(filename5);
        
        var service1 = new EchipaService(repo1);
        var service2 = new ElevService(repo2);
        var service3 = new JucatorService(repo3);
        var service4 = new JucatorActivService(repo4,repo3);
        var service5 = new MeciService(repo5,repo4,repo3);
        
        Ui ui = new Ui(service1, service2, service3, service4, service5);
        ui.run();
    }
}