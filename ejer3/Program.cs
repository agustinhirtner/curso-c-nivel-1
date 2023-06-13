using System;

namespace ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            double km,v,t;

            Console.WriteLine("ingresar ");
            km=double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar");
            v=double.Parse(Console.ReadLine());

            t=km/v;

            Console.WriteLine("el tiempo que va a tardar " + t);



        }
    }
}
