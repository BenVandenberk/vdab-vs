using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkiezingen
{
    class BinaryChoice
    {
        public bool? Decision { get; set; }
        public IChoice Choice1 { get; set; }
        public IChoice Choice2 { get; set; }

        /* To bias choices towards choice1, set a value > 1
         * For no bias, set a value of 1
         * To bias choices towards choice2, set a value < 1
         */ 
        public double Choice1Bias { get; set; }
    }
}
