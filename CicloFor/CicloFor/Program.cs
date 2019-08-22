using System;

namespace CicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y,z;
            Console.WriteLine("Bienvenido a mi programa");

            Console.WriteLine("Dime el primer numero");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dime el segundo numero");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dime de cuanto en cuanto quieres que vaya");
            z = Convert.ToInt32(Console.ReadLine());

            if(x>y)
            {
                for (int i=x;i>y;i-=z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                for (int i=x;i<y;i+=z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}
