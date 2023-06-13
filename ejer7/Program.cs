using System;

namespace ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("ingresar");
            n=int.Parse(Console.ReadLine());

            if(n>0){
                Console.WriteLine("positivo");
            }else if(n<0){
                Console.WriteLine("negativo");
            }else if(n==0){
                Console.WriteLine("cero");
            }
        }
    }
}
