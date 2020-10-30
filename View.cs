using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCalculadora
{
    class View
    {
        public View()
        {
            Console.Clear();
            this.exibir("----------------------------------Calculadora Simples-------------------------------------");
            this.exibir(" operações compativeis: Adição, Multiplicação, Raiz e Potenciação");
            this.exibir("Digite o Primeiro numero");                                           
        }
        public void exibir( String content )
        {           
            Console.WriteLine(content);            
        }

        //exibição para o usuario

    }
}
