using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_integrador
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Looping

            string resp = "S", Gen = "";
            double Peso = 0, Altura = 0, IMC = 0;

            while (resp == "S")
            {
                Console.Clear();

                Console.WriteLine("Calcule seu IMC");
                Console.WriteLine("Entre com seu Peso (Kg): ");
                Peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Entre com sua Altura (m): ");
                Altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual seu genero (M/F): ");
                Gen = Console.ReadLine();

                // calculo
                IMC = Peso / (Altura * Altura);
                IMC = Peso / Math.Pow(Altura, 2);

                //passar os resultados

                Console.Write("Deseja fazer outra consulta? (S/N): ");
                resp = Console.ReadLine().ToUpper();
            }





            }
        }
}
