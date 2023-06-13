using System;

namespace ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,p;

            Console.WriteLine("ingresar");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar");
            n3=int.Parse(Console.ReadLine());

            p=(n1+n2+n3)/3;

            Console.WriteLine("promedio " + p);
        }
    }
}
