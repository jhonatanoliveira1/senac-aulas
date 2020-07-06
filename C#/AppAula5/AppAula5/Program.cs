using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAula5
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
                Console.Write("O valor da nota: {0:c}, o valor da taxa 2%: {1:c}", valorDaNotaFiscal, valorDaNotaFiscal * 0.02);
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



            /* teste */

            Console.Write("\n\nExercício 4\n\n");
            Console.Write("\nDigite o valor da nota fiscal:");
            valorDaNotaFiscal = Convert.ToDouble(Console.ReadLine());

            if (valorDaNotaFiscal <= 999)
            {
                Console.Write("\nValor da nota {0:c}, \nValor da taxa 2% {1:c} \nValor total {2:c}", valorDaNotaFiscal, valorDaNotaFiscal * 0.02, valorDaNotaFiscal + valorDaNotaFiscal * 0.020);
            }
            else if (valorDaNotaFiscal <= 2999)
            {
                Console.Write("\nValor da nota: {0:c}, \nValor da taxa 2.5% {1:c} \nValor total {2:c}", valorDaNotaFiscal, valorDaNotaFiscal * 0.025, valorDaNotaFiscal + valorDaNotaFiscal * 0.025);
            }
            else if (valorDaNotaFiscal <= 6999)
            {
                Console.Write("\nValor da nota {0:c} \nValor da taxa 2.8% {1:c} \nValor total {2:c}", valorDaNotaFiscal, valorDaNotaFiscal * 0.028, valorDaNotaFiscal + valorDaNotaFiscal * 0.028);
            }
            else
            {
                Console.Write("\nValor da nota {0:c} \nValor da taxa 3% {1:c} \nValor total {2:c}", valorDaNotaFiscal, valorDaNotaFiscal * 0.030, valorDaNotaFiscal + valorDaNotaFiscal * 0.030);
            }
            Console.ReadKey();



           
        }
    }
}
