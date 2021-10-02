using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace CalculadoraSmarapd
{
    public class Calculadora
    {
        public List<string> ResultadoArmazenados { get; private set; }
        private List<decimal> Resultado = new List<decimal>();
        public Calculadora()
        {
            ResultadoArmazenados = new List<string>();
        }

        public int GetTamanhoLista()
        {
            return ResultadoArmazenados.Count();
        }
        public void Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            ResultadoArmazenados.Add(primeiroNumero.ToString() + " + " +
                segundoNumero.ToString() + " = " +
                (primeiroNumero + segundoNumero).ToString());
            Resultado.Add(primeiroNumero + segundoNumero);
        }

        public void Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            ResultadoArmazenados.Add(primeiroNumero.ToString() + " - " +
                segundoNumero.ToString() + " = " +
                (primeiroNumero - segundoNumero).ToString());
            Resultado.Add(primeiroNumero - segundoNumero);
        }

        public void Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            ResultadoArmazenados.Add(primeiroNumero.ToString() + " * " +
                segundoNumero.ToString() + " = " +
                (primeiroNumero * segundoNumero).ToString());
            Resultado.Add(primeiroNumero * segundoNumero);
        }

        public void Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            if (segundoNumero == 0)
            {
                Console.WriteLine("Impossível dividir por 0");
                Console.WriteLine("Digite o segundo número valido:");
                segundoNumero = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (segundoNumero != 0)
                {
                    ResultadoArmazenados.Add(primeiroNumero.ToString() + " / " +
                        segundoNumero.ToString() + " = " +
                        (primeiroNumero / segundoNumero).ToString());
                    Resultado.Add(primeiroNumero / segundoNumero);
                }
                else
                {
                    Console.WriteLine("Sua calculadora será encerrada.");
                    Environment.Exit(0);

                }
            }
            else
            {
                ResultadoArmazenados.Add(primeiroNumero.ToString() + " / " +
                                    segundoNumero.ToString() + " = " +
                                    (primeiroNumero / segundoNumero)
                                    .ToString());
                Resultado.Add(primeiroNumero / segundoNumero);
            }
        }
       
        public override string ToString()
        {
            return "O resultado é: " + Resultado.Last().ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
