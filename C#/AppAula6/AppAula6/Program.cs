using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAula6
{
    class Program
    {
        static void Main(string[] args)
        {
            Double nro = 0;
            String s, n;
            int x, y;
            int idade;
            bool brasileiro;
            string resp;
            double valorDaNotaFiscal;


            /*
            Console.Write("\n\nExercício 1\n\n");
            Console.Write("Digite um número:");
            x = Convert.ToInt16(Console.ReadLine());
            if (x % 2 == 0)
            {
            Console.WriteLine("\nO número é par");
            }
            else
            {
            Console.WriteLine("\nO número é impar");
            }
            Console.ReadKey();



            Console.Write("\n\nExercício 2\n\n");
            Console.Write("Digite o 1° número:");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o 2° número:");
            y = Convert.ToInt16(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("\nO numero <1ºNRO> é maior que o numero <2ºNRO>");
            }
            else if (y > x)
            {
                Console.WriteLine("\nO numero <2ºNRO> é maior que o numero <1ºNRO>");
            }
            else
            {
                Console.WriteLine("\nO numero <1ºNRO> é igual ao numero <2ºNRO>");
            }
            Console.ReadKey();



            Console.Write("\n\nExercício 3\n\n");
            Console.WriteLine("\nDigite sua idade:");
            idade = Convert.ToInt16(Console.ReadLine());
            if (idade < 16) 
            {
            Console.WriteLine("Não esta apto a votar");
            Console.ReadKey();
            }

            else 
            {
            Console.Write("Você é Brasileiro? (S/N)\n");
            resp = Console.ReadLine();
            brasileiro = (resp == "S");
            }
            if (idade > 16)
            {
                Console.WriteLine("Esta apto a votar");
            }
            Console.ReadKey();


    
            Console.Write("\n\nExercício 4\n\n");
            Console.Write("\nDigite o valor da nota fiscal:");
            valorDaNotaFiscal = Convert.ToDouble(Console.ReadLine());

            if (valorDaNotaFiscal <= 999)
            {
            Console.Write("O valor da nota: {0:c}, o valor da taxa 2%: {1:c}", valorDaNotaFiscal, valorDaNotaFiscal*0.02);
            }
            else if (valorDaNotaFiscal <= 2999)
            {
            Console.Write("O valor da nota: {0:c}, o valor da taxa 2.5% {1:c}", valorDaNotaFiscal, valorDaNotaFiscal * 0.025);
            }
            else if (valorDaNotaFiscal <= 6999)
            {
            Console.Write("O valor da nota: {0:c}, o valor da taxa 2.8% {1:c}", valorDaNotaFiscal, valorDaNotaFiscal * 0.028);
            }
            else 
            {
            Console.Write("O valor da nota: {0:c}, o valor da taxa 3% {1:c}", valorDaNotaFiscal, valorDaNotaFiscal * 0.030);
            }
            Console.ReadKey();
            */

            /* Aula 06 */

            
            int soma = 0;
            int total = 2;
            for (int j = 0; j < 5; j += 1)
            {
                total = total * 2;
            }
            Console.Write("\n\nExercício 1\n\n");
            Console.WriteLine("O total é: {0}", total);
            Console.ReadKey();



            Console.Write("\n\nExercício 2\n\n");
            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }
            Console.WriteLine("A soma dos números de um até mil é: {0} ", +soma);
            Console.ReadKey();



            Console.Write("\n\nExercício 3\n\n");
            for (int h = 1; h <= 100; h++)
            {
                if (h % 3 == 0)
                    Console.Write("{0},", h);
            }
            Console.ReadKey();



            Console.Write("\n\nExercício 4\n\n");
            for (int l = 1; l < 100; l++)
            {
                if (l % 3 != 0)
                    Console.Write("{0},", l);
            }
            Console.ReadKey();



            Console.Write("\n\nExercício 5\n\n");
            for (int k = 1; k < 30; k++)
            {
                if (k % 3 == 0 || k % 4 == 0)
                    Console.Write("{0},", k);
            }
            Console.ReadKey();


            
            Console.Write("\n\nExercício 6\n\n");
            Console.Write("Insira o primeiro numero:");

            Console.Write("Insira o ultimo numero:");
            for (int v = 1; v <= 10; v++)
            {
                for (int n = 1; n <= v; v++)
                {
                    fatorial *= n;
                }
                Console.Write("fatorial de {0} é {1}", v, fatorial);
            }
            Console.ReadKey();









        }
    }
}
