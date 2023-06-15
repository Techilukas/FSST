using System.Net.WebSockets;

namespace Rechteck_Fsst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anzahl der Rechtecke: ");
            int count = int.Parse(Console.ReadLine());
            int[] numbers = FillArrayRanomNumebr(count, 99, 1);
            Console.WriteLine("Länge des Rechtecks: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Höhe des Rechtecks: ");
            int height = int.Parse(Console.ReadLine());
            DrawSquars(numbers, width, height);
            ShowIntArray(numbers, width-2, width);
        }

        public static void DrawSquars(int[] numbers)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write(" ## ");
            }
            Console.WriteLine();
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write(" ## ");
            }
            Console.WriteLine();
        }

        public static int[] FillArrayRanomNumebr(int count, int max, int min)
        {
            Random rnd = new Random();
            int[] values = new int[count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rnd.Next(min, max +1);
            }
            return values;
        }

        public static void ShowIntArray(int[] values, int space)
        {
            for (int j = 0; j < space/2; j++)
            {
                Console.Write($" ");
            }
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write("" + values[i], 2);
                for (int j = 0; j < space; j++)
                {
                    Console.Write($" ");
                }

            }
        }

        public static void ShowIntArray(int[] values, int space, int multiplicator)
        {
            for (int j = 0; j < space / 2; j++)
            {
                Console.Write($" ");
            }
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{values[i] * multiplicator,4}");
                for (int j = 0; j < space; j++)
                {
                    Console.Write($" ");
                }

            }
        }

        public static void DrawSquars(int[] numbers, int width)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" ");
                for(int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = 0; i < width-2; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    Console.Write(" ");
                    Console.Write("#");
                    for (int l = 0; l < width-2; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("#");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        public static void DrawSquars(int[] numbers, int width, int height)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = 0; i < height - 2; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        Console.Write(" ");
                        Console.Write("#");
                        for (int l = 0; l < (width - 4) / 2; l++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write($"{numbers[j],2}");
                        for (int l = 0; l < (width - 4) / 2; l++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("#");
                        Console.Write(" ");
                    }
                    Console.WriteLine(); 
                }
                else
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        Console.Write(" ");
                        Console.Write("#");
                        for (int l = 0; l < width - 2; l++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("#");
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}