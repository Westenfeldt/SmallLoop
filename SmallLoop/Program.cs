using System;

namespace SmallLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =1; i <=20; i++)
            {
                Console.WriteLine(i);
            }

            int whileI = 20;

            do
            {
                whileI++;
                Console.WriteLine(whileI);
            } while (whileI <= 39);
            int whileINT = 41;
            while( whileINT <=60)
            {
                Console.WriteLine(whileINT);
                whileINT++;
            }

        }
    }
}
