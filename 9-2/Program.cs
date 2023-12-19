using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi 1. simbolu rindu: ");
            string simboli1 = Console.ReadLine();

            Console.Write("Ievadi 2. simbolu rindu: ");
            string simboli2 = Console.ReadLine();

            // zvaigznītes

            string simboli3 = "";

            for (int i = 0; i < simboli1.Length; i++)
            {
                if ((int)simboli1[i] <= 57 && (int)simboli1[i] >= 48)
                {
                    simboli3 += "*";
                }
                else
                {
                    simboli3 += simboli1[i];
                }
            }
            Console.WriteLine(simboli3);

            // lowercase2caps

            string simboli4 = "";

            for (int i = 0; i < simboli2.Length; i++)
            {
                if ((int)simboli2[i] >= 97 && (int)simboli2[i] <= 122)
                {
                    simboli4 += (char)(simboli2[i] - 32);
                }
                else
                {
                    simboli4 += simboli2[i];
                }
            }

            Console.WriteLine(simboli4);


            Console.WriteLine($"1. simbolu rindas garums: {simboli1.Length}");
            Console.WriteLine($"2. simbolu rindas garums: {simboli2.Length}");


            int rem = 0;
            string apvienojums = "";

            for (int i = 0; i < simboli2.Length / 2; i++)
            {
                apvienojums += simboli2[i];
                rem++;
            }

            apvienojums += simboli1;

            for (int i = rem; i < simboli2.Length; i++)
            {
                apvienojums += simboli2[i];
            }
            Console.WriteLine($"Rindu apvienojums: {apvienojums}");

            string rinda;
            do
            {
                Console.Write("Ievadiet 3. simbolu rindu: ");
                rinda = Console.ReadLine();
            } while (string.IsNullOrEmpty(rinda));

            int reizes = 0;

            for (int i = 0; i <= apvienojums.Length - rinda.Length; i++)
            {
                string buffer = "";
                for (int j = i; j < rinda.Length + i; j++)
                {
                    buffer += apvienojums[j];
                }
                if (buffer == rinda)
                {
                    reizes++;
                }
            }

            Console.WriteLine($"3. rinda atkārtojas apvienojumā {reizes} reizes.");

            Console.ReadLine();
        }
    }
}