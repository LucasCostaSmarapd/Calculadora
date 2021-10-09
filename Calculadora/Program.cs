using System;
using System.Globalization;
namespace CalculadoraSmarapd
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Menu menu = new Menu();
            Recursao();
            void Recursao()
            { 
                try
                {
                    Console.WriteLine(menu.Principal());
                    calculadora.PegarOpção();
                    Console.WriteLine(calculadora.Calcular());
                    calculadora.Sair();
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Erro: Você deve digitar números para realizar os cálculos.\n\n");
                    Console.ReadKey();
                    Console.Clear();
                    Recursao();
                }
                Recursao();
            }
        }
    }
}
