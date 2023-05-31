namespace Array_Übung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] melinski = new int[10];
            int[] yoshi = new int[10];
            Random rnd  = new Random();
            int niki;

            for (int i = 0; i < melinski.Length; i++)
            {
                melinski[i] = rnd.Next(1, 100);
            }
            Console.Write($"Array: {melinski[0]}");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($" | {melinski[j]}");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                niki = 0;

                for (int j = 0; j < 10; j++)
                {
                    if (melinski[j] == i)
                    {
                        niki++;
                    }
                }

                if (niki != 0)
                {
                    Console.WriteLine($"{i} occcurs {niki} times(s)");
                }
            }

            Console.WriteLine("Sollen die Zahlen absteigend(1) oder aufsteigend(0)");
            string input = Console.ReadLine();
            if(input == "1")
            {

                for (int i = 0; i < yoshi.Length; i++)
                {
                    int b = 0;
                    for (int j = 0; j < melinski.Length; j++)
                    {
                        if (melinski[j] > b)
                        {
                            b = melinski[j];
                        }
                    }
                    yoshi[i] = b;
                    int c = Array.IndexOf(melinski, yoshi[i]);
                    melinski[c] = 0;
                }

                Console.Write($"Array: {yoshi[0]}");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($" | {yoshi[j]}");
                }
                Console.WriteLine();

            }
            else if (input == "0")
            {
                for (int i = 0; i < yoshi.Length; i++)
                {
                    int b = 100;

                    for (int j = 0; j < melinski.Length; j++)
                    {

                        if (melinski[j] < b)
                        {
                            b = melinski[j];
                        }
                    }
                    yoshi[i] = b;
                    int c = Array.IndexOf(melinski, yoshi[i]);
                    melinski[c] = 100;
                }

                Console.Write($"Array: {yoshi[0]}");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($" | {yoshi[j]}");
                }
                Console.WriteLine();
            }
        }
    }
}