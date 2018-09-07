using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkiezingen
{
    class Kandidaat
    {
        public int KandidaatPositie { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public int NaamStemmen { get; set; }
        public int OvergedragenStemmen { get; set; }
        public int TotaalStemmen => NaamStemmen + OvergedragenStemmen;

    }
}
