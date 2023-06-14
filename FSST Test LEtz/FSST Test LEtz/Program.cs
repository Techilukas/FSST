namespace FSST_Test_LEtz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Show_Number(3);
            int c = Power_Number(3);
            Console.WriteLine(c);
            
        }

        public static void Show_Number(int a)
        {
            int b = a * 5;
            Console.WriteLine(b);
        }
  
        public static int Power_Number(int a)
        {

            return Convert.ToInt32(Math.Pow(a, 2));
        }

    }
}