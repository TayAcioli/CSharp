using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4 - Conversoes e outros Tipos Numericos.");

            double salario = 1200.50;

            //O int eh uma variavel de 32 bits.
            int salarioEmInteiro = (int)salario;

            Console.WriteLine("Seu salario em double: " + salario + ". Seu salario em inteiro: " + salarioEmInteiro + ".");

            //O long eh uma variavel de 64 bits.
            long idadeLong = 13000000000;

            Console.WriteLine(idadeLong);

            //O short eh uma variavel de 16 bits.
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            //Sempre que for usar float, por f apos numero ou o compilador vai confundir com double.
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("A execucao acabou, pressione enter para sair...");
            Console.ReadLine();
        }
    }
}
