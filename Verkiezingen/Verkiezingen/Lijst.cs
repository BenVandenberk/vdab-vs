using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkiezingen
{
    class Lijst
    {
        public string Naam { get; set; }
        public int Nummer { get; set; }
        public int Verkiesbaarheidscijfer { get; set; }
        public int AantalZetels { get; set; }
        public int AantalLijstStemmen { get; set; }
        public int AantalNaamEnNaamLijstStemmen { get; set; }
        public int AantalOverTeDragenStemmen { get; set; }
        public int Stemcijfer { get; set; }

        public List<Kandidaat> Kandidaten { get; set; }

        public Lijst(string naam, int nummer, IEnumerable<Kandidaat> kandidaten)
        {
            this.Naam = naam;
            this.Nummer = nummer;
            this.Kandidaten = new List<Kandidaat>(kandidaten);
        }

    }
}
