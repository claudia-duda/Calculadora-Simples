using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCalculadora
{
    class Controller
    {
        private string[] valor; //valores digitados vai ser em string e depois na classe operation vai ser convertido
        private View view;

        public Controller(View view)
        {
            this.view = view;
            this.valor = new string[3]; //definindo o tamanho do array

        }

        public void start() // primeiro metodo para exibir
        {   
            double apenasNumero;
            this.valor[0] = this.ler(); // guarda o primeiro numero  
           
            this.valor[0] = tratamentoNumeros(this.valor[0]);
            
            this.view.exibir("escolha um operador : [ + ] [ * ] [ / ] [ ^ ]");
            this.valor[1] = this.ler();

            try
            {
                this.run();
            }
            catch (Exception)
            {
                this.erro();
                this.run();
            }

            //   this.view.exibir("Resultado: " + this.resultado());
        }
        private string tratamentoNumeros(string valor){
            double apenasNumero;
            while(!Double.TryParse(valor, out apenasNumero)){
                this.view.exibir("valor incorreto, digite um numero");
                valor = this.ler();
            }

            return valor;

        }
        private void run()
        {         
            Operation op = this.escolher(); //crio a variavel do tipo operação e recebe a op adequada para o calculo
            this.view.exibir("Digite o Segundo numero");
            this.valor[2] = this.ler();
            this.valor[2] = tratamentoNumeros(this.valor[2]);
            this.view.exibir("Resultado: " + op.calcular(valor[0], valor[2])); //manda para a classe filha especifica
            this.view.exibir("Aperte enter para um novo calculo");
        }

        private string ler()//recebe o valor
        {
            return Console.ReadLine();
        }

        private Operation escolher()// retorna o tipo da operação
        {

            Operation op;
            switch (this.valor[1])
            {

                case "+":
                    op = new Adicao();
                    break;
                case "-":
                    op = new Subtracao();
                    break;
                case "*":
                    op = new Multiplicacao();
                    break;
                case "/":
                    op = new Divisao();
                    break;

                case "^":
                    op = new Potenciacao();
                    break;
                default:
                    throw new Exception("Operador incorreto"); //lançando exceção
                                                               // this.erro();
                    break;
            }

            return op;
        }
        private void erro()
        {
            do
            {
                this.view.exibir("Valor do operador esta incorreto,digite novamente");
                this.valor[1] = this.ler();
            } while ((this.valor[1] != "+")
            && (this.valor[1] != "-")
            && (this.valor[1] != "/")
            && (this.valor[1] != "*"));
        }

    }
}