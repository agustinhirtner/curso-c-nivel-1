using System;

namespace ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("INGRESAR");
            n=int.Parse(Console.ReadLine());

            if(n>10){
                Console.WriteLine("es mayor");
            }else {
                Console.WriteLine("no es mayor");
            }
        }
    }
}
