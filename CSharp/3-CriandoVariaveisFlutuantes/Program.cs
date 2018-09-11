using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisFlutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 3 - Criando Variaveis Flutuantes.");

            double salario = 1200.70;

            Console.WriteLine("O Seu salario e: " + salario + "!");

            double idade;
            idade = 15.0 / 2;

            Console.WriteLine(idade);

            idade = 5 / 3;

            Console.WriteLine("5 / 3 = " + idade);

            idade = 5 / 3.0;

            Console.WriteLine("5 / 3 = " + idade);

            Console.WriteLine("A execucao acabou, pressione enter para sair...");
            Console.ReadLine();
        }
    }
}
