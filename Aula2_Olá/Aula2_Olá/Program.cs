using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2_Olá
{
    class Program
    {
        static void Main(string[] args)
        {
            string saudacao, nome;
            saudacao = "Olá ";
            Console.Write("Seu nome:");
            nome = Console.ReadLine();
            Console.Write(saudacao + nome);
            Console.ReadKey();
            
            
        }
    }
}
