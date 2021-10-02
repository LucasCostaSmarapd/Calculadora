using System;

namespace CalculadoraSmarapd
{

    public partial class Menu
    {   
        public string Principal()
        {
            return "\n##########-MENU-#########\n" +
                   "1 - Soma.                  \n" +
                   "2 - Subtração.             \n" +
                   "3 - Multiplicação.         \n" +
                   "4 - Divisão.               \n" +
                   "5 - Visualizar resultados armazenados.\n"+
                   "99 - Sair.\n";
        }
        public enum GetOpcao
        {
            Soma = 1,
            Subtração = 2,
            Multiplicação = 3,
            Divisão = 4,
            Resultados = 5,
            Sair = 99
        }
        public void VolteSempre()
        {
            Console.WriteLine("Volte Sempre");
        }
    }
}
