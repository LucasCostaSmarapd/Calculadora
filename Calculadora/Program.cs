using System;
using System.Globalization;
namespace CalculadoraSmarapd
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal primeiroNumero;
            string operador;
            decimal segundoNumero;
            Calculadora calculadora = new Calculadora();
            Menu menu = new Menu();
            Console.WriteLine("Bem vindo a calculadora maluca do Lucas!");
            void Recursao()
            { 
                Console.WriteLine(menu.Principal()); 
                operador = Console.ReadLine();
                Console.WriteLine("Opção selecionada: " + (Menu.GetOpcao)int.Parse(operador));
                if(operador == "5")
                {
                    if (calculadora.GetTamanhoLista() > 0)
                        calculadora.ResultadoArmazenados.ForEach(x => Console.WriteLine(x));
                    else
                        Console.WriteLine("Não existe resultados armazenados.");
                    Recursao();
                }
                else if(operador == "99")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("Digite o primeiro número:");
                primeiroNumero = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Digite o segundo número:");
                segundoNumero = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (operador)
                {
                    case "1":
                        calculadora.Somar(primeiroNumero, segundoNumero);
                        Console.WriteLine(calculadora);
                        break;
                    case "2":
                        calculadora.Subtrair(primeiroNumero, segundoNumero);
                        Console.WriteLine(calculadora);
                        break;
                    case "3":
                        calculadora.Multiplicar(primeiroNumero, segundoNumero);
                        Console.WriteLine(calculadora);
                        break;
                    case "4":
                        calculadora.Dividir(primeiroNumero, segundoNumero);
                        Console.WriteLine(calculadora);
                        break;
                    default:
                        Console.WriteLine("Você digitou seu cálculo errado!");
                        break;
                }
                Console.WriteLine("Deseja sair?\n" +
                                  "99 - Sair\n" +
                                  "1 - Menu Principal\n");
                if (Console.ReadLine() != "99")
                {
                    Console.WriteLine("Bem vindo a calculadora maluca do Lucas!");
                }
                else
                {
                    menu.VolteSempre();
                    Environment.Exit(0);

                }
                Recursao();
            }
            Recursao();


        }
    }
}
