using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 9: Método com Parâmetros e Retorno

    Descrição: Crie um método chamado ConcatenarStrings
    que receba duas strings como parâmetros e retorne 
    a concatenação dessas duas strings. 
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex09
    {
        public static string ConcatenarString(string texto1, string texto2)
        {   
            // Retonar o texto1 concatenado com o texto2
            return texto1 + " + " + texto2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----- PROGRAMA QUE CONCATENA TEXTOS -----");

            // Entrada de Dados
            Console.WriteLine("Digite um texto: ");
            string texto1 = Console.ReadLine();
            Console.WriteLine("Digite outro texto: ");
            string texto2 = Console.ReadLine();

            // Saída de Dados
            Console.WriteLine("--- Resultado ---");
            Console.WriteLine(ConcatenarString(texto1, texto2));
        }
    }
}
