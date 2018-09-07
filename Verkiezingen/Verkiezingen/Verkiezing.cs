using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkiezingen
{
    class Verkiezing
    {
        public int AantalGeldigeBiljetten { get; set; }
        public int AantalBlancoEnOngeldigeBiljetten { get; set; }
        public int TotaalAantalBiljetten => AantalGeldigeBiljetten + AantalBlancoEnOngeldigeBiljetten;

        public List<Lijst> Lijsten { get; set; }
        public int AantalLijsten => this.Lijsten.Count;

        public Verkiezing(IEnumerable<Lijst> lijsten)
        {
            this.Lijsten = new List<Lijst>(lijsten);
        }

    }
}
