using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 3: Método com Parâmetros e Retorno 

    Descrição: Crie um método chamado Somar que 
    receba dois inteiros como parâmetros e 
    retorne a soma desses dois números. 
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex03
    {
        public static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Somar(9, 9));
        }
    }
}
