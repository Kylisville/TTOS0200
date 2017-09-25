using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Hissi
    {

        private const int ylinkerros = 5;
        private int kerros;
        public int Kerros
        {

            get { return kerros; }
            set {
                if (value > ylinkerros)
                    kerros = ylinkerros;
                else if (value < 1)
                    kerros = 1;
                else
                    kerros = value;
            }
            
        }

    }
}
