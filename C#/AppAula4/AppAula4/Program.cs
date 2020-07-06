using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAula4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int nr1 = 0;
            int nr2 = 0;
            string nm = null, ende = null, tel = null;
            int nrm0 = 0, nrm1 = 0;
            Double nro = 0;
            Double med = nro * 1.01;
            Double pr1 = 0, pr2;           



            Console.Write("Exercício 1\n\n");
            Console.WriteLine("Imprimir a mensagem: É PRECISO FAZER TODOS OS" + 
                    " EXERCÍCIOS PARA APRENDER");
            Console.WriteLine("É PRECISO FAZER TODOS OS EXERCÍCIOS PARA APRENDER");
            Console.ReadKey();



            Console.Write("\n\nExercício 2\n\n");
            Console.WriteLine("Imprimir seu nome.");
            Console.WriteLine("Jhonatan de Oliveira");
            Console.ReadKey();



            Console.Write("\n\nExercício 3\n\n");
            Console.WriteLine("Criar um algoritimo que imprima O " +
                "produto(mutiplicação) entre 28 e 43.");
            Console.WriteLine("RESP: A mutiplicação ente 28 e 43 é {0}", 28*43);
            Console.ReadKey();



            Console.Write("\n\nExercício 4\n\n");
            Console.WriteLine("Criar um algoritmo que imprima a média" +
                "aritmética entre os números 8, 9 e 7. ");
            Console.WriteLine("RESP: A média entre 8, 9 e 7 é {0}", (8 + 9 + 7) / 3);
            Console.ReadKey();



            Console.Write("\n\nExercício 5\n\n");
            Console.WriteLine("Ler dois números inteiros e imprimir o produto. ");
            Console.Write("Digite o 1° número: ");
            nr1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o 2° número: ");
            nr2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("RESP O produto entre {0} e {1} é {2}.", nr1, nr2, nr1 * nr2);

            

            Console.Write("\n\nExercício 6\n\n");
            Console.WriteLine("Ler um número inteiro e imprimir seu sucessor e seu antecessor.");
            Console.Write("Digite um número: ");
            nr1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("RESP: O número digitado foi {0},\n seu sucessor é {1}" +
                "\n e seu antecessor é {2}.", nr1, nr1 + 1, nr1 - 1);
            Console.ReadKey();

            

            Console.Write("\n\nExercício 7\n\n");
            Console.WriteLine("Ler nome, endereço e telefone e imprimi-los. ");
            Console.Write("Digite nome:");
            nm = Console.ReadLine();
            Console.Write("Digite endereço:");
            ende = Console.ReadLine();
            Console.Write("Digite o telefone:");
            tel = Console.ReadLine();
            Console.WriteLine("RESP: \nO nome digitado foi {0}, \n"+
                "O endereço digitado foi {1}, \n"+
                "O telefone digitado foi {2}", nm, ende, tel );
            Console.ReadKey();

          


            Console.Write("\n\nExercício 8\n\n");
            Console.WriteLine("Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem: Soma.");
            Console.Write("Digite o 1° número:");
            nrm0 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o 2° número:");
            nrm1 = Convert.ToInt16(Console.ReadLine());
            int resultado = nrm0 + nrm1;
            Console.WriteLine("A soma é igual: {0}", resultado);
            Console.ReadKey();



            Console.Write("\n\nExercício 9\n\n");
            Console.WriteLine("Ler um número real(numero com virgula) e imprimir a terça parte deste número.");
            Console.Write("Digite um número:");
            nro = Convert.ToDouble(Console.ReadLine());
            Console.Write("A terça parte deste número é {0}", nro / 3);
            Console.ReadKey();

            

            Console.Write("\n\nExercício 10\n\n");
            Console.WriteLine("Entrar com dois números reais e imprimir a média aritmética com a mensagem “Média” antes do resultado.");
            Console.Write("Digite o 1° número:");
            nrm0 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o 2° número:");
            nrm1 = Convert.ToInt16(Console.ReadLine());
            int media = (nrm0 + nrm1) / 2;
            Console.WriteLine("A Média dos nuemroes é: {0}", media);
            Console.ReadKey();



            Console.Write("\n\nExercício 11\n\n");
            Console.WriteLine("Fazer um algoritmo que possa entrar com o saldo de uma aplicação e imprima o novo saldo, considerando o reajuste de 1%.");
            Console.Write("Digite um número:");
            nro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Saldo: {0:f}", nro * 1.01);
            Console.ReadKey();



            Console.Write("\n\nExercício 12\n\n");
            Console.WriteLine("Entrar com as notas da PR1 e PR2 e imprimir a média final");
            Console.WriteLine("Nota PR1:");
            pr1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota PR2:");
            pr2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Média Final:{0}",(pr1+pr2)/2);
            Console.ReadKey();





        }
    }
}