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
            Console.ReadLine();
        }
    }
}
