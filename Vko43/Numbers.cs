using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vko43
{
    class Numbers
    {
        public List<int> Int { get; set; }
        public List<double> Double { get; set; }
        private string pathint = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\intTxt.txt";
        private string pathdouble = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\doubleTxt.txt";
        public Numbers()
        {
            Int = new List<int>();
            Double = new List<double>();

        }
        public void Inputs()
        {
            bool Inputcorrect = true;
            while (Inputcorrect)
            {
                Console.WriteLine("Syötä kokonais- tai desimaaliluku. Jos syöttö on jotain muuta, ohjelma suljetaan");
                if (double.TryParse(Console.ReadLine(), out double input))
                {
                    if ((input % 1) == 0)
                    {
                        Int.Add(Convert.ToInt32(input));
                    }
                    else
                    {
                        Double.Add(input);
                    }
                }
                else
                {
                    Inputcorrect = false;
                }
            }
        }

        public void AddToTxt()
        {
            try
            {
                using (StreamWriter sw = File.AppendText(pathint))
                {
                    foreach (int i in Int)
                    {
                        sw.WriteLine(i);
                    }
                    Console.WriteLine("Lisätty kokonaisluvut {0}", pathint);
                };
                using (StreamWriter sw = File.AppendText(pathdouble))
                {
                    foreach (double d in Double)
                    {
                        sw.WriteLine(d);
                    }
                    Console.WriteLine("Lisätty desimaaliluvut {0}", pathdouble);
                };

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ReadTxt()
        {
            try
            {
                using (StreamReader sr = File.OpenText(pathint))
                {
                    string s = " ";
                    Console.WriteLine("Contents of int.txt: ");
                    while((s=sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                using (StreamReader sr = File.OpenText(pathdouble))
                {
                    string s = " ";
                    Console.WriteLine("Contents of double.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
