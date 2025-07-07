namespace Fsst_nachilf_8
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Wie viele Werte: ");
        //    int length = int.Parse(Console.ReadLine());
        //    int[] numbers = new int[length];
        //    numbers = Fill_Array(numbers, 0, 100);
        //    Show_Int_Arry(numbers);
        //    Console.Write("Welche Zahl soll ersetzt werden: : ");
        //    int tochange = int.Parse(Console.ReadLine());
        //    Console.Write("Mit welcher Zahl soll sie ersetzt werden: ");
        //    int changenumber = int.Parse(Console.ReadLine());
        //    numbers = Change_Int_Array(numbers, changenumber, tochange);
        //    Show_Int_Arry(numbers);
        //}

        //public static int[] Fill_Array(int[] values, int min, int max)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        values[i] = rnd.Next(min, max+1);
        //    }
        //    return values;
        //}

        //public static void Show_Int_Arry(int[] values)
        //{
        //    for (int i = 0;i < values.Length;i++)
        //    {
        //        Console.WriteLine(i+1 + ": " + values[i]);
        //    }
        //}

        //public static int[] Change_Int_Array(int[] values, int changenumber, int tochange)
        //{
        //    for(int i = 0; i <values.Length;i++)
        //    {
        //        if(tochange == values[i])
        //        {
        //            values[i] = changenumber;
        //        }
        //    }

        //    return values;
        //}


        static void Main(string[] args)
        {
            Console.Write("Geben sie die Sietenlänge ein: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Geben sie die Anzahl dert Quadrate ein: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Geben sie die das Zeichen ein mit dem das Quadrat gezeichnet wird: ");
            char charakter = char.Parse(Console.ReadLine());

            Draw_Squares(length, count, charakter);

        }

        //public static void Draw_Squares(int length, int count, char character)
        //{
        //    for (int k = 0; k < count; k++)
        //    {
        //        for (int i = 0; i < length; i++)
        //        {
        //            Console.Write(character);
        //        }
        //        Console.WriteLine();
        //        for (int i = 0; i < length - 2; i++)
        //        {
        //            Console.Write(character);
        //            for (int j = 0; j < length - 2; j++)
        //            {
        //                Console.Write(" ");
        //            }
        //            Console.Write(character);
        //            Console.WriteLine();
        //        }
        //        for (int i = 0; i < length; i++)
        //        {
        //            Console.Write(character);
        //        }
        //        Console.WriteLine(); 
        //    }
        //}

        public static void Draw_Squares(int length, int count, char character)
        {


            for (int k = 0; k < count; k++)
            {

                for (int i = 0; i < length; i++)
                {
                    Console.Write(character);

                }
                Console.Write("  ");
            }

            Console.WriteLine();
            for (int i = 0; i < length - 2; i++)
            {
                for (int k = 0; k < count; k++)
                {
                    Console.Write(character);
                    for (int j = 0; j < length - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(character);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            for (int k = 0; k < count; k++)
            {

                for (int i = 0; i < length; i++)
                {
                    Console.Write(character);

                }
                Console.Write("  ");
            }

        }


    }
}