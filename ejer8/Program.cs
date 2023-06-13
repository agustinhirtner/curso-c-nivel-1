using System;

namespace ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            double v,d,t=0;

            Console.WriteLine("ingresar venta");
            v=double.Parse(Console.ReadLine());

            if(v<1000){
                t=t+v;
                Console.WriteLine("no hay descuento " + t);
            }else if(v>1000&&v<5000){
                d=v*0.10;
                t=v-d;
                Console.WriteLine("total con descuento del 10% " + t);
            }else if(v>5000){
                d=v*0.18;
                t=v-d;
                Console.WriteLine("total con descuento del 18% " +t);
            }
        }
    }
}
