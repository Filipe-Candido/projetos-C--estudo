using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comando para ler os dados em c# é o Console.Readline()
            Console.WriteLine("Digite uma frase:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine("Você digitou: "+x);
            


            string[] vetor = Console.ReadLine().Split(' ');
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);  
            Console.WriteLine(b);
            Console.WriteLine(c);
            


        }
    }
}