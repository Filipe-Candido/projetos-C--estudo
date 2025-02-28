using System;
using   System.Globalization;

/*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados da peça 1: ");
            string[] peca1 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(peca1[0]);
            int numPeca1 = int.Parse(peca1[1]);
            double valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);


            Console.WriteLine("Informe os dados da peça 2:");
            string[] peca2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(peca2[0]);
            int numPeca2 = int.Parse(peca2[1]);
            double valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);


            double valorPagar = (numPeca1 * valorPeca1) + (numPeca2 * valorPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}