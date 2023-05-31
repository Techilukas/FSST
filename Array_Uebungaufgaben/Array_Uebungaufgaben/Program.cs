namespace Array_Uebungaufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1)
            Console.WriteLine("Beispiel 1");
            Random rnd = new Random();
            int[] h = new int[10];
            for(int i = 0; i < h.Length; i++)
            {
                h[i] = rnd.Next(1, 101);
            }
            for (int i = 0; i < h.Length; i++)
            {
                Console.WriteLine($"{i} | {h[i]}");
            }

            // 4)
            Console.WriteLine();
            Console.WriteLine("Beispiel 4");
            string[] g = {"Blons", "Partenen", "Thüringen", "Dornbirn", "Feldkirch", "Schruns" };
            string[] c = {"Thüringerberg", "Schlumpfhausen", "Sonntag", "Blons", "Bregenz", "Partenen" };
            for(int i = 0; i < g.Length; i++)
            {
                for (int j = 0; j < c.Length;j++)
                {
                    if (g[i] == c[j])
                    {
                        Console.WriteLine($"Die Stadt {g[i]} ist in beiden arrays vorhanden.");
                    }
                }
            }

            // 10)
            Console.WriteLine();
            Console.WriteLine("Beispiel 10");
            int[] d = new int[10];
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = rnd.Next(0, 31);
            }
            for(int i = 0; i < d.Length; i++)
            {
                for (int j = 1;j < d.Length; j++)
                {
                    if (i != j)
                    {
                        if (d[i] == d[j])
                        {
                            d[i] = 0;
                            d[j] = 0;
                        }
                    }
                }
            }
            for(int i = 0; i < d.Length; i++)
            {
                Console.WriteLine($"{i} | {d[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Beispiel 7");
            int n = 10;
            int ergebniss = 0;
            //int[] a = new int[n];
            //int[] b = new int[n];
            int[] a = {1, 2, 3, 4, 5, 6, 7 , 8, 9 ,10 };
            int[] b = {23, 234, 432, 324, 235, 745, 75, 547, 457, 894 };
            for (int i = 0; i < n; i++)
            {
                ergebniss += (a[i] * b[i]);
            }

            Console.WriteLine(ergebniss);
            Console.ReadKey();
        }
    }
}