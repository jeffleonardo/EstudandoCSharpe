using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoCSharpe
{
    class Program
    {
        static void Main(string[] args)
        {

            //Int - numeros inteiros
            //Float / double / decimal - numeros com ponto flutuante
            //Bool - true ou false
            //String - "texto"
            //Char - caracter
            /*
            int segundaGuerraMundial = 1942;
            double meuPeso = 84.5;
            string corFavorita = "azul";
            float velocidadeF1 = 200.50f;
            bool segundaGuerraAconteceu = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(segundaGuerraAconteceu);
            Console.WriteLine(meuPeso);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);

            velocidadeF1 = 300.50f;
            corFavorita = "vermelho";

            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            */

            /*
            var corFavorita = "azul";
            var meuNome = "jefferson leonardo da silva";
            var minhaIdade = 29;

            Console.WriteLine(corFavorita);
            Console.WriteLine(meuNome);
            Console.WriteLine(minhaIdade);*/

            //variavel dinamica - a variavel pode ser alterada
            /*
            dynamic corFavorita = "vermelho";

            Console.WriteLine(corFavorita);

            corFavorita = "azul";

            Console.WriteLine(corFavorita);*/

            //const float PI = 3.141516f; o valor da constante nao pode ser alterado

            //entrada de dados do teclado
            /*
            String nome = "";
            Console.WriteLine("Difite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Meu nome é " + nome);*/

            //float divisao = 6.0f / 2; dividir numero decimal por inteiro retorna um decimal

            /*
            int num1;
            int num2;
            int soma;

            //converter
            //<tipo>.Parse(<objeto da conversão>);
            //Convert.To(<objeto da conversao>);
            Console.WriteLine("Calcular Números: ");
            Console.WriteLine("Digite o número 1: ");
            num1 = int.Parse(Console.ReadLine()); //convertido
            Console.WriteLine("Digite o número 2: ");
            num2 = int.Parse(Console.ReadLine()); //convertido
            soma = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + soma);

            Console.ReadLine();
            */


        }

    }
}
