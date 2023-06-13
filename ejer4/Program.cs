using System;

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            double tf,t,tt;

            Console.WriteLine("ingresar");
            tf=double.Parse(Console.ReadLine());

            t=tf*0.05;
            tt=t+15000;

            Console.WriteLine("total " + tt);
        }
    }
}
