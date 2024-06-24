using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 6: Método com Parâmetros e Retorno 

    Descrição: Crie um método chamado EhPar que 
    receba um inteiro como parâmetro e retorne 
    verdadeiro se o número for par e falso se for ímpar. 
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex06
    {
        public static bool EhPar(int numero)
        {
            // Verifica se o Resto da Divisão de numero ÷ 2 é igual a 0, esse calculo é utilizado para verificar se um número é Par, se a verificação for verdadeira o Método retorna "true"
            if (numero % 2 == 0)
            {
                return true;
            }

            // Se a verificação acima for falsa o Método irá retornar "false"
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----- PROGRAMA QUE VERIFICA SE O NUMERO É PAR -----");

            // Entrada de Dados
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            string verificacao;

            // Processamento

            // Conversão de Booleano para um texto (Para que o resultado fique mais Fácil de Entender)
            if (EhPar(numero) == true)
            {
                verificacao = "Sim";
            }
            else
            {
                verificacao = "Não";
            }

            // Saída de Dados
            Console.WriteLine("--- Resultado ---");
            Console.WriteLine("O numero digitado é Par? " + verificacao);
        }
    }
}
