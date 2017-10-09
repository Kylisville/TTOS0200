﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Radio
    {

        public bool Paalla { get; set; }
        private const int maksimitaajuus = 26000;
        private int taajuus;
        public int Taajuus
        {
            get { return taajuus; }
            set
            {
                if (value > maksimitaajuus)
                    taajuus = maksimitaajuus;
                else if (value < 2000)
                    taajuus = 2000;
                else
                    taajuus = value;
            }
        }
       
        private const int maksimiaani = 9;
        private int aani;
        public int Aani
        { get { return aani; }
            set
            {
                if (value > maksimiaani)
                     aani = maksimiaani;
                else if (value < 0)
                    aani = 0;
                else
                    aani = value;
            }
        }
    
    }
    public class Asetukset : Radio
    {
     
    }
}
