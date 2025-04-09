using System.Globalization;
using Laboratorul10.Service;

namespace Laboratorul10.UI;

public class Ui
{
     private EchipaService _echipaService;
     private ElevService _elevService;
     private JucatorService _jucatorService;
     private JucatorActivService _jucatorActivService;
     private MeciService _meciService;

     public Ui(EchipaService echipaService, ElevService elevService, JucatorService jucatorService,
          JucatorActivService jucatorActivService, MeciService meciService)
     {
          this._elevService = elevService;
          this._jucatorService = jucatorService;
          this._jucatorActivService = jucatorActivService;
          this._meciService = meciService;
     }

     private void cerinta1()
     {
          Console.WriteLine("Introduceti ID-ul echipei");
          string input = Console.ReadLine(); 
          var jucatori = _jucatorService.FindAllEchipa(input);
          jucatori.ForEach(x=>Console.WriteLine(x));
     }

     private void cerinta2()
     {
          Console.WriteLine("Introduceti ID-ul echipei");
          string input = Console.ReadLine();
          Console.WriteLine("Introduceti ID-ul unui meci");
          string input2 = Console.ReadLine();
          var jucatoriActivi = _jucatorActivService.FindAllJucatoriActiviEchipaMeci(input, input2);
          jucatoriActivi.ForEach(x=>Console.WriteLine(x));
     }

     private void cerinta3()
     {
          Console.WriteLine("Introduceti data de inceput");
          DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
          Console.WriteLine("Introduceti data de sfarsit");
          DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
          var meciuri = _meciService.FindAllMeciuriPerioada(startDate, endDate);
          meciuri.ForEach(x=>Console.WriteLine(x));
     }

     private void cerinta4()
     {
          Console.WriteLine("Introduceti ID-ul unui meci");
          string input = Console.ReadLine();
          var scor = _meciService.scorMeci(input);
          Console.WriteLine(scor);
     }

     private void print_menu()
     {
          Console.WriteLine("-------------------------");
          Console.WriteLine("1.Toti jucatorii unei echipe");
          Console.WriteLine("2.Toti jucatorii activi ai unei echipe");
          Console.WriteLine("3.Toate meciurile dintr-o perioada");
          Console.WriteLine("4.Scorul de la un anumit meci");
          Console.WriteLine("0.Exit");
          Console.WriteLine("-------------------------");
     }

     public void run()
     {
          while (true)
          {
               print_menu();
               Console.WriteLine("Introduceti optiunea: ");
               string input = Console.ReadLine();
               int numar = int.Parse(input);

               if (numar == 0)
                    break;
               if (numar == 1)
                    cerinta1();
               if (numar == 2)
                    cerinta2();
               if (numar == 3)
                    cerinta3();
               if (numar == 4)
                    cerinta4();
          }
     }
}