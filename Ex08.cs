using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 8: Método com Parâmetros e Retorno

    Descrição: Crie um método chamado CalcularFatorial 
    que receba um inteiro positivo como parâmetro e 
    retorne o fatorial desse número.
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex08
    {
        public static int CalcularFatorial(int fatorial)
        {
            int resultado = 1;

            // Loop para Calcular o Valor do Fatorial
            do
            {
                resultado *= fatorial;
                fatorial--;
            } while (fatorial >= 1);

            // Retorna o Resultado final do Fatorial
            return resultado;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----- PROGRAMA QUE CALCULA O FATORIAL -----");

            // Entrada de Dados
            Console.WriteLine("Digite um número: ");
            int numeroDoFatorial = Convert.ToInt32(Console.ReadLine());

            // Saída de Dados
            Console.WriteLine("--- Resultado ---");
            Console.WriteLine($"O Fatorial de {numeroDoFatorial} é: {CalcularFatorial(numeroDoFatorial)} ");
        }
    }
}