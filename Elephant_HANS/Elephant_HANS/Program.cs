using System.Diagnostics;

namespace FSST_ÜBen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = 0;

            Console.WriteLine("Wie viele Telefonnummern sollten erstellt werden");
            bool isinputok = false;

            while (!isinputok)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out count) && count <= 100 && count > 0)
                {
                    isinputok = true;
                }
                else
                {
                    Console.WriteLine("Geben Sie eine Zahl ein zwischen 1 - 100");
                }
            }
            Console.WriteLine();

           


            int[] telephonenumbers = new int[count];

            Random rnd = new Random();

            for (int i = 0; i < telephonenumbers.Length; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    int a = rnd.Next(0, 10);
                    if (a == 0)
                    {
                        telephonenumbers[i] *= 10;
                    }
                    else
                    {
                        telephonenumbers[i] += a * Convert.ToInt32(Math.Pow(10, j));
                    }
                }

            }


            for (int i = 0; i < telephonenumbers.Length; i++)
            {
                Console.WriteLine($"{i + 1,2}. 0664/{telephonenumbers[i]}");
            }
        }
    }

}