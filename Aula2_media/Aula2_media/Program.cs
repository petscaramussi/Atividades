using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2_media
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double media1, media2, media3, media4, mediaFinal;
            Console.WriteLine("Nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nota 1: ");
            media1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 2:");
            media2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            media3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 4: ");
            media4 = Convert.ToDouble(Console.ReadLine());
            mediaFinal = (media1 + media2 + media3 + media4) / 4;
            Console.WriteLine("Aluno: "+nome);
            Console.WriteLine("Media final: "+mediaFinal.ToString("f1"));
            if (mediaFinal > 6)
            {
                Console.WriteLine("Parabens");
            }
            else if(mediaFinal == 5 )
                {
                    Console.WriteLine("ta na media");
                }

            else
            {
                Console.WriteLine("Precisa melhorar...");
            }
            Console.ReadKey();
            
        }
    }
}
