using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 7: Método sem Parâmetros com Retorno 

    Descrição: Crie um método chamado ObterDataAtual 
    que não receba parâmetros e retorne a data atual 
    como uma string no formato "dd/MM/yyyy". 
*/

namespace ExerciciosLogicaMetodos
{
    internal class Ex07
    {
        public static string ObterDataAtual()
        {
            // Armazena na Variável dataAtual o valor da Data Atual
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");

            return dataAtual;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----- PROGRAMA QUE MOSTRA A DATA ATUAL -----");

            // Saída de Dados
            Console.WriteLine("");
            Console.WriteLine("A data atual é: " + ObterDataAtual());
        }
    }
}
