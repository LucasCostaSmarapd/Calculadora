using System;

namespace CalculadoraSmarapd
{

    public class Menu
    {   
        public string Principal()
        {
            return "Bem vindo a calculadora maluca do Lucas!\n\n" +
                   "\n##########-MENU-#########\n" +
                   "1 - Soma.                  \n" +
                   "2 - Subtração.             \n" +
                   "3 - Multiplicação.         \n" +
                   "4 - Divisão.               \n" +
                   "5 - Visualizar resultados armazenados.\n"+
                   "99 - Sair.\n";
        }
      
        public void VolteSempre()
        {
            Console.WriteLine("Volte Sempre");
        }
    }
}
