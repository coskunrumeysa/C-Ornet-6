using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Proje_4
{
    internal class Program
    {
        static void Main(string[] args)
            
        {   baslangic:
            
            //Declaration variables
            //Byte take value between 0-256 . If user give a number bigger than 256 program cant work.
            byte number;

            Console.Write("Lütfen bir sayı giriniz: ");

            // Byte inventory
            number = byte.Parse(Console.ReadLine());

            if(number>0)
            {
                Console.WriteLine("Sayı pozitif bir sayıdır.");
            }

            else if (number <0)
            {
                Console.WriteLine("Sayı negatif bir sayıdır.");
            }

            else
            {
                Console.WriteLine("Bu sayı işaretsiz bir sayıdır.");
                goto baslangic;

            }

            Console.ReadKey();
        }
    }
}
