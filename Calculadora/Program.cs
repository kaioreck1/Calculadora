using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("Escolha a opção");
                Console.WriteLine("1 - SOMAR");
                Console.WriteLine("2 - SUBTRAIR");
                Console.WriteLine("3 - MULTIPLICAR");
                Console.WriteLine("4 - DIVISÃO");
                Console.WriteLine("0 - SAIR");

                char opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        Console.WriteLine("Digite o primeiro valor:");
                        double valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o Segundo Valor: ");
                        double valor2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {valor1 + valor2}");
                        break;

                    case '2':
                        Console.WriteLine("Digite o primeiro valor: ");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o Segundo valor: ");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {valor1 - valor2} ");
                        break;

                    case '3':
                        Console.WriteLine("Digite o primeiro valor");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {valor1 * valor2}");
                        break;

                    case '4':
                        Console.WriteLine("Digite o primeiro valor");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o Segundo Valor");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {valor1 / valor2}");
                        break;

                    case '0':
                        Console.WriteLine("Saindo da Calculadora");
                        return;

                    default:
                        Console.WriteLine("Opcção Invalida. Tente Novamente");
                        break;
                }
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear(); // Limpa a tela para exibir o menu novamente
            }
        }
    }
}