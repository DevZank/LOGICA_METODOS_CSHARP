using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 10: Método com Parâmetros e Retorno

    Descrição: Crie um método chamado CalcularMedia
    que receba três números decimais como parâmetros
    e retorne a média desses números. 
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex10
    {
        public static double CalcularMedia(double valor1, double valor2, double valor3)
        {
            // Faz o calculo da média
            double media = (valor1 + valor2 + valor3) / 3;

            // Retorna a média
            return media;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----- PROGRAMA QUE CALCULA A MÉDIA -----");

            // Entrada de Dados
            Console.WriteLine("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            // Saída de Dados
            Console.WriteLine("--- Resultado ---");
            Console.WriteLine($"A média dos valores é: {Math.Round(CalcularMedia(valor1, valor2, valor3), 2)}");
        }
    }
}
