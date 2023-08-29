using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1er_problema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int MayorValor;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            num3 =int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                MayorValor = num1;
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    MayorValor = num2;
                }
                else
                {
                    MayorValor = num3;
                }
            }
            Console.WriteLine("El número mayor es: " + MayorValor.ToString());
            Console.ReadKey();
        }
    }
}
