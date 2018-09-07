using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkiezingen
{
    class StemComputer
    {
        public Verkiezing Verkiezing { get; set; }

        public StemComputer(Verkiezing verkiezing)
        {
            this.Verkiezing = verkiezing;
        }

        public void StemWillekeurig()
        {

        }

        /**
         * Verschillende willekeurige stem mogelijkheden:
         * 1) BlancoOfOngeldig
         * 2) Geldig (met x lijsten)
         *  2.1) Lijststem voor 1 van de x lijsten
         *  2.2) Naamstem(men) voor 1 van de x lijsten (met y kandidaten voor de betreffende lijst)
         *      2.2.1) [1,y] naamstemmen
         **/

    }
}
