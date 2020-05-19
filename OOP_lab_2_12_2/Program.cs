using System;

namespace OOP_lab_2_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;

            while (x <= 6)
            {
                double y = 1 / (1 - Math.Sqrt(x));

                if (1 - Math.Sqrt(x) == 0)
                {
                    Console.WriteLine("x = {0:f1}, y - не iснує", x);
                }
                else
                {
                    Console.WriteLine("x = {0:f1}, y = {1,7:f4}", x, y);
                }

                x += 0.5;
            }
        }
    }
}
