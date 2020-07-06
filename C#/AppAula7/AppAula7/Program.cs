using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAula7
{
    class Program
    {
        static void Main(string[] args)
        {

            


            Console.Write("\n\nExercício 1\n\n");

            int[,] numeros = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };           
            Console.ReadKey();



            Console.Write("\n\nExercício 2\n\n");
            int nr1 = 0;
            string[] semana = new string[] {"domingo", "segunda", "terça", "quarta", "quinta", "sexta", "sabado"};

            Console.Write("Dgite um numero entre 1 e 7:");
            nr1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O dia da semana é {0}", semana[nr1-1]);
            Console.ReadKey();

        }
    }
}
