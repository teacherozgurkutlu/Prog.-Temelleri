﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kod;
            string[] plaka = new string[5];
            plaka[0] = "Adana";
            plaka[1] = "Adıyaman";
            plaka[2] = "Afyon";
            plaka[3] = "Ağrı";
            plaka[4] = "Amasya";
            Console.Write("Plakayı giriniz : ");
            kod = Convert.ToInt16(Console.ReadLine());
            if (kod == 1)
            {
                Console.Write("Girdiğiniz Plaka kodu {0}'na aittir : ", plaka[0]);
            }
            else if (kod == 2)
            {
                Console.Write("Girdiğiniz Plaka kodu {0}'na aittir : ", plaka[1]);
            }
            else if (kod == 3)
            {
                Console.Write("Girdiğiniz Plaka kodu {0}'na aittir : ", plaka[2]);
            }
            else if (kod == 4)
            {
                Console.Write("Girdiğiniz Plaka kodu {0}'na aittir : ", plaka[3]);
            }
            else if (kod == 5)
            {
                Console.Write("Girdiğiniz Plaka kodu {0}'na aittir : ", plaka[4]);
            }
            else
            {
                Console.Write("Bu program 1-5 arası plaka kodlarını tanır : ");
            }

            Console.ReadKey();

        }
    }
}
