using System;

namespace ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1,n2,n3,n4;

           Console.WriteLine("ingresar");
           n1=int.Parse(Console.ReadLine());
           Console.WriteLine("ingresar");
           n2=int.Parse(Console.ReadLine());
           Console.WriteLine("ingresar");
           n3=int.Parse(Console.ReadLine());
           Console.WriteLine("ingresar");
           n4=int.Parse(Console.ReadLine());

           if(n1<n2&&n2<n3&&n3<n4){
            Console.WriteLine("el menor es " + n1 );
            }else if(n2<n1&&n1<n3&&n3<n4){
                Console.WriteLine("el menor es " + n2);
            }else if(n3<n1&&n1<n2&&n2<n4){
                Console.WriteLine("el menor es " + n3);
            }else{
                Console.WriteLine("el menor es " + n4);
            }
        }
    }
}
