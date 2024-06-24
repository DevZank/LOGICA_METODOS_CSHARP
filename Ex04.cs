using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 4: Método com Parâmetros e Retorno 

    Descrição: Crie um método chamado Multiplicar 
    que receba dois inteiros como parâmetros e 
    retorne o produto desses dois números. 
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex04
    {
        public static int Multiplicar(int numero1, int numero2)
        { 
            return numero1 * numero2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Multiplicar(9, 3));
        }
    }
}
