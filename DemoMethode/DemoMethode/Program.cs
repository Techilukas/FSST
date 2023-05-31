using System.Security.Cryptography;

namespace DemoMethode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            //ShowHelp();

            //WriteStars(15);
            //WriteStars(-1);
            //WriteStars(100, ConsoleColor.Blue);
            //WriteStars(3, ConsoleColor.Green);

            //Console.WriteLine(RectangleArea(5.33, 2342.33));
            //Console.WriteLine($"5.33 * 2342.33 = {RectangleArea(5.33, 2342.33)}");

            //DrawBox(5, 5, '0');
            //DrawBox(20, 20, '+');
            //DrawArrow(Direction.Left, 20, 2);
            ArrowRight(3, 6, '\u2580');
            ArrowRight(5, 60, '#', ConsoleColor.DarkGreen);
            ArrowRight(6, 10, '#', 3);
            ArrowDownAdvanced(3, 6, 3);
        }
        /// <summary>
        /// Zeigt einen Hilfe Text an
        /// </summary>
        public static void ShowHelp()
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Das wäre ein hilfe Text.");
            Console.ForegroundColor = defaultColor;
        }

        /// <summary>
        /// es wird eine gewisse Anzahl an Strenchen ausgeben
        /// </summary>
        /// <param name="count">Anzahl der Sterne</param>
        public static void WriteStars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }

            if (count > 0)
            {
                Console.WriteLine(); 
            }
        }

        /// <summary>
        /// schreibt eine Anzahl an Sternchen in einer gewiesen Farbe
        /// </summary>
        /// <param name="count">Anzahl der Sternchen</param>
        /// <param name="color">Farbe der Sternchen</param>
        public static void WriteStars(int count, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            if (count > 0)
            {
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;
        }

        /// <summary>
        /// berechnet die Fläche eines Rechteckes
        /// </summary>
        /// <param name="length">Länge der Rechtecks</param>
        /// <param name="width">Breite des Rechtecks</param>
        /// <returns>Fläche</returns>
        public static double RectangleArea (double length, double width)
        {
            return length * width;
        }

        public static void DrawBox(int length, int width, char character)
        {
            for(int i = 0; i < length; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
            for (int i = 0; i < width; i++)
            {
                Console.Write(character);
                for(int j = 2; j < length; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(character);
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }

        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        public static void DrawArrow(Direction dir, int stumpheight, int topheight)
        {
            if(dir == Direction.Up)
            {
                for(int i = 0; i < topheight; i++)
                {
                    Console.WriteLine(new string(' ', topheight - i) + new string('*', i*2+1) + new string(' ', topheight - i));
                }
                for(int i = 0; i < stumpheight; i++)
                {
                    Console.WriteLine(new string(' ', topheight) +"*");
                }
            }
            else if (dir == Direction.Down)
            {
                for (int i = 0; i < stumpheight; i++)
                {
                    Console.WriteLine(new string(' ', topheight) + "*");
                }
                for (int i = 1; i < topheight+1; i++)
                {
                    Console.WriteLine(new string(' ', i) + new string('*', topheight *2 + 1 - i*2) );
                }
                
            }
            else if (dir == Direction.Left)
            {
                for (int i = 0; i < topheight +1; i++)
                {
                    Console.WriteLine(new string(' ', topheight - i + 1) + new string('*', i));
                }
                Console.WriteLine(new string('*', stumpheight + topheight + 1));
                for (int i = 0; i < (topheight); i++)
                {
                    Console.WriteLine(new string(' ',i +1) + new string('*', topheight - i));
                }
            }
            else if (dir == Direction.Right)
            {
                for (int i = 0; i < (topheight); i++)
                {
                    Console.WriteLine(new string(' ', stumpheight) + new string('*', i +1));
                }
                Console.WriteLine(new string('*', stumpheight + topheight + 1));
                for (int i = topheight-1; i > -1 ; i--)
                {
                    Console.WriteLine(new string(' ', stumpheight) + new string('*', i + 1));
                }
            }
        }

        public static void ArrowRight(int headLength, int totalLength, char character)
        {
            for (int i = 0; i < headLength-1; i++)
            {
                Console.WriteLine(new string(' ', totalLength - headLength) + new string(character, i + 1));
            }
            Console.WriteLine(new string(character, totalLength));
            for (int i = headLength - 2; i > -1; i--)
            {
                Console.WriteLine(new string(' ', totalLength-headLength) + new string(character, i + 1));
            }
        }

        public static void ArrowRight(int headLength, int totalLength, char character, ConsoleColor col)
        {
            ConsoleColor defcol = Console.ForegroundColor;
            Console.ForegroundColor = col;

            for (int i = 0; i < headLength -1; i++)
            {
                Console.WriteLine(new string(' ', totalLength - headLength) + new string(character, i + 1));
            }
            Console.WriteLine(new string(character, totalLength));
            for (int i = headLength - 2; i > -1; i--)
            {
                Console.WriteLine(new string(' ', totalLength - headLength) + new string(character, i + 1));
            }
            Console.ForegroundColor=defcol;
        }

        public static void ArrowRight(int headLength, int totalLength, char character, int thickness)
        {
            for (int i = 0; i < headLength - 1-(thickness/2 -1); i++)
            {
                Console.WriteLine(new string(' ', totalLength - headLength) + new string(character, i + 1));
            }
            for (int i = 0; i < thickness/2 +1; i++)
            {
                Console.WriteLine(new string(character, totalLength-headLength) + new string(character, headLength - (thickness / 2 - 1) + i));
            }
            for (int i = 0; i < thickness / 2 ; i++)
            {
                Console.WriteLine(new string(character, totalLength - headLength) + new string(character, headLength - i));
            }
            for (int i = headLength - 2 - (thickness / 2 - 1); i > -1; i--)
            {
                Console.WriteLine(new string(' ', totalLength - headLength) + new string(character, i + 1));
            }
        }
        public static void ArrowDownAdvanced(int headLength, int totalLength, int thickness)
        {
            for (int i = 0; i < totalLength - headLength; i++)
            {
                Console.WriteLine(new string(' ', headLength - (thickness-1)/2 ) + new string('#', thickness));
            }
            for (int i = 1; i < headLength + 1; i++)
            {
                Console.WriteLine(new string(' ', i) + new string('#', headLength * 2 + 1 - i * 2));
            }
        }

    }
}