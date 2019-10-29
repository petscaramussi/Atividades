using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2_Adição
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            Console.WriteLine("Digite o 1º valor:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor:");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("o resultado é:" +soma);
            Console.ReadKey();
        }
    }
}
