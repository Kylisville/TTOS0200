using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    class Vahvistin
    {
        private const int maksimi = 100;
        private int aani;
        public int Aani
        {

            get { return aani; }
            set
            {
                if (value > maksimi)
                    aani = maksimi;
                else if (value < 0)
                    aani = 0;
                else
                    aani = value;
            }
        }

        }
    }
