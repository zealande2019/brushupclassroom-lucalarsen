using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn { get; set; }

        public List<Studerende> KlasseListe { get; } = new List<Studerende>();

        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {

        }
    }
}
