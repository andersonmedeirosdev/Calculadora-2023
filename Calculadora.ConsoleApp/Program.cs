using System.Security.Cryptography;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do { 
            Console.Clear();

            
            Console.WriteLine("Calculadora TOP 2023");

            Console.WriteLine("Digite 1 para adicionar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine("Digite 4 para dividir");

            Console.WriteLine("Digite S para sair");

            string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
                {
                    continue;
                }

                Console.WriteLine();

            Console.Write("Digite o primeiro numero: ");
            
            decimal primeironumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");

            decimal segundonumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;


            if (operacao == "1")
            {
                resultado = primeironumero + segundonumero;
            }

            else if (operacao == "2")
            {
                resultado = primeironumero - segundonumero;
            }

            else if (operacao == "3")
            {
                resultado = primeironumero * segundonumero;
            }

            else if (operacao == "4")
            {
                while(segundonumero == 0)
                {
                    Console.WriteLine("Opção Invalida");
                    Console.WriteLine("Escreva o segundo numero novamente:");
                    segundonumero = Convert.ToDecimal(Console.ReadLine());
                }

                resultado = primeironumero / segundonumero;
            }
                Console.WriteLine("O resultado da operação é: " + Math.Round(resultado, 2));
                Console.ReadLine();
            } while(true);
        }
    }
}