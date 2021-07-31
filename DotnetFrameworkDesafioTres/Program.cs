using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFrameworkDesafioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para solucionar a seguinte expressão atribua valor a: x, y e d?"+"\n\n"+"Expressão: x + y + d + 5 * 77 + 8 - 10 * (8/3)"+"\n");
            Console.WriteLine("Digite o valor de X");
            double valorX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y");
            double valorY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de D");
            double valorD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O resultado da expressão para os valores informados é " + ((valorX + valorY + valorD + (5 * 77) + 8 - (10 * (8 / 3)))));
            Console.ReadKey();


        }
    }
}
