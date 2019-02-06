using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseRum = new KlasseRum();
            klasseRum.KlasseNavn = "3B";
            klasseRum.SemesterStart = new DateTime(2018,9,4);

            Studerende student1 = new Studerende("Luca", 12, 28);
            Studerende student2 = new Studerende("Louise", 5, 4);
            Studerende student3 = new Studerende("Martin", 6, 13);

            klasseRum.KlasseListe.Add(student1);
            klasseRum.KlasseListe.Add(student2);
            klasseRum.KlasseListe.Add(student3);

            foreach (var item in klasseRum.KlasseListe)
            {
                Console.WriteLine(item.Navn);
                Console.WriteLine(item.Årstid());
            }


            optælling("sommer", klasseRum);
            optælling("vinter", klasseRum);
            optælling("forår", klasseRum);
            optælling("efterår", klasseRum);

            Console.ReadLine();
        }
        static void optælling(string sæson, KlasseRum klasseRum)
        {
            int count = 0;
            if (sæson == "sommer")
            {
                count = klasseRum.KlasseListe.Where(x => x.Fødselsmåned == 6 || x.Fødselsmåned == 7 || x.Fødselsmåned == 8).Count();
            }
            if (sæson == "forår")
            {
                count = klasseRum.KlasseListe.Where(x => x.Fødselsmåned == 3 || x.Fødselsmåned == 4 || x.Fødselsmåned == 5).Count();
            }
            if (sæson == "vinter")
            {
                count = klasseRum.KlasseListe.Where(x => x.Fødselsmåned == 12 || x.Fødselsmåned == 1 || x.Fødselsmåned == 2).Count();
            }
            if (sæson == "efterår")
            {
                count = klasseRum.KlasseListe.Where(x => x.Fødselsmåned == 9 || x.Fødselsmåned == 10 || x.Fødselsmåned == 11).Count();
            }
            Console.WriteLine($"{count} ");
        }
    }
}
