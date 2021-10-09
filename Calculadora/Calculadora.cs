using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Calculadora;
using Enum = Calculadora.Enum;

namespace CalculadoraSmarapd
{
    public class Calculadora : Enum, ICalculadora
    {
        private string Operador { get; set; }
        private decimal PrimeiroNumero { get; set; }
        private decimal SegundoNumero { get; set; }
        private List<string> ResultadoArmazenados { get; set; }

        public Calculadora()
        {
            ResultadoArmazenados = new List<string>();
        }
        #region //Pegar opção e Valores
        public void PegarOpção()
        {
            string[] verificador = {"1", "2", "3", "4" };
            Console.Write("Digite a opção desejada: ");
            Operador = Console.ReadLine();
            if (verificador.Contains(Operador))
            {
                Console.WriteLine("Opção selecionada: " + (Opcao)int.Parse(Operador) + "\n");
                PegarPrimeiroNumero();
                PegarSegundoNumero();
            }
            else
                Console.WriteLine("Opção selecionada: " + (Opcao)int.Parse(Operador) + "\n");       
        }

        public void PegarPrimeiroNumero()
        {
            Console.Write("Digite o primeiro número: ");
            PrimeiroNumero = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public void PegarSegundoNumero()
        {
            Console.Write("Digite o segundo número: ");
            SegundoNumero = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        #endregion

        #region //Calcular
        public string Calcular()
        {
            decimal? calculo = null;
            switch (Operador)
            {
                case "1":
                    calculo = PrimeiroNumero + SegundoNumero;
                    break;
                case "2":
                    calculo = PrimeiroNumero - SegundoNumero;
                    break;
                case "3":
                    calculo = PrimeiroNumero * SegundoNumero;
                    break;
                case "4":
                    if(SegundoNumero == 0)
                    {
                        Console.WriteLine("Nenhum número pode ser dividido por 0.");
                    }
                    else
                    {
                        calculo = PrimeiroNumero / SegundoNumero;
                    }
                    break;
                case "5":
                    if (ResultadoArmazenados.Count > 0)
                        ResultadoArmazenados.ForEach(x => Console.WriteLine(x));
                    else
                        Console.WriteLine("Não existe resultados armazenados.");
                    break;
                case "99":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Você não digitou a opção corretamente");
                    break;
            }
            if(SegundoNumero == 0 && Operador == "4"|| int.Parse(Operador) > 4) {
                return null;
            }
            ResultadoArmazenados.Add(PrimeiroNumero.ToString() + " + " +
                    SegundoNumero.ToString() + " = " +
                    calculo.ToString() + "\n\n");
            return ResultadoArmazenados.Last();
        }
        #endregion

        public void Sair()
        {
            Console.WriteLine("Deseja sair?\n" +
                                  "99 - Sair\n" +
                                  "1 - Menu Principal\n");
            if(Console.ReadLine() == "99")
            {
                Environment.Exit(0);
            }
        }

    }
}
