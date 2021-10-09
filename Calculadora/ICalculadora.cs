using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public interface ICalculadora
    {
        void PegarOpção();
        void PegarPrimeiroNumero();
        void PegarSegundoNumero();
        string Calcular();
        void Sair();

    }
}
