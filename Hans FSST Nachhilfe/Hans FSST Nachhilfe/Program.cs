namespace Hans_FSST_Nachhilfe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Wie viele Telefonnummern sollten erstellt werden: ");

            bool isinputok = false;
            while (!isinputok)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out count) && count <= 100)
                {
                    isinputok = true;
                }
                else
                {
                    Console.WriteLine("Geben sie ein Zahl ein zwischen 1 - 100.");
                }
            }


            double[] telephonenubers = new double[count];

            Random rnd = new Random();

            //for (int i = 0; i < telephonenubers.Length; i++)
            //{
            //    telephonenubers[i] += rnd.Next(0, 9);
            //    telephonenubers[i] += rnd.Next(0, 9) * 10;
            //    telephonenubers[i] += rnd.Next(0, 9) * 100;
            //    telephonenubers[i] += rnd.Next(0, 9) * 1000;
            //    telephonenubers[i] += rnd.Next(0, 9) * 10000;
            //    telephonenubers[i] += rnd.Next(0, 9) * 100000;
            //}
            for (int i = 0; i < telephonenubers.Length; i++)
            {
                double a = 0;
                for (double j = 0; j < 8; j++)
                {
                    int random = rnd.Next(0, 10);
                    if(random == 0)
                    {
                        a = a * 10;
                    }
                    else
                    {
                        a += random * Math.Pow(10, j);
                    }
                    telephonenubers[i] = a;
                }
            }

            for (int i = 0; i < telephonenubers.Length; i++)
            {
                Console.WriteLine($"{i+1,2}. 0664/{telephonenubers[i]}");
            }



        }
    }
}