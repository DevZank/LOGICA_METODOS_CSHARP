using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 2: Método com Parâmetro sem Retorno 

    Descrição: Crie um método chamado ImprimirMensagem 
    que receba uma string como parâmetro e imprima essa 
    mensagem na tela. 
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex02
    {
        public static void ImprimirMensagem(string mensagem)
        {
            Console.WriteLine("Mensagem: " + mensagem);
        }

        public static void Main(string[] args)
        {
            ImprimirMensagem("Olá, mundo! \nEstá é uma mensagem passada em um Parâmetro");
        }
    }
}
