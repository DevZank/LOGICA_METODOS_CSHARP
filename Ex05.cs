using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 5: Método com Parâmetros e Retorno 

    Descrição: Crie um método chamado MaiorNumero 
    que receba dois inteiros como parâmetros e 
    retorne o maior entre eles. 
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex05
    {
        public static int MaiorNumero(int numero1, int numero2)
        {
            // Verifica se o numero1 é maior que o numero2 caso seja verdadeiro o Método irá retornar "numero1" 
            if (numero1 > numero2)
            {
                return numero1;
            }

            // Verifica se o numero2 é maior que o numero1 caso seja verdadeiro o Método irá retornar "numero2" 
            else if (numero1 < numero2)
            {
                return numero2;
            }

            // Se nenhuma das Verificações acima for Verdadeira o Método irá retornar "0"
            else
            {
                return 0;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----- PROGRAMA QUE VERIFICA O MAIOR NUMERO -----");

            // Entrada de Dados
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Saída de Dados
            Console.WriteLine("--- Resultado ---");
            Console.WriteLine("O maior numero é: " + MaiorNumero(num1, num2));
        }
    }
}
