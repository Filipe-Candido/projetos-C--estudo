using System;
using System.Runtime.CompilerServices; // Nmae space padrão do dot net para manipulaçõa de programas//

namespace PrimeiroProjeto // agrupamento de classes relacionadas//
{
    internal class Program //classe declarada
    {
        static void Main(string[] args) // declaração para ponto de entrada para execução do programa
        {

            string name = "Filipe Candido"; // string aspas duplas (de valor imultavel) uma vez declarada não se altera
            SByte x = 100; 
            bool y = false;//booleano
            char genero = 'F'; //caracter aspas simples
            object objeto1 = "Maria das graças";//tipo generico aceita qualquer valor
            int n1= int.MaxValue; // maior valor de int
            int n2= int.MinValue;// menor valor de int



            Console.WriteLine("Hello World!");
            Console.WriteLine( x );
            Console.WriteLine( genero );
            Console.WriteLine(y);
            Console.WriteLine(name);
            Console.WriteLine(objeto1);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}

// Variaveis
//não pode iniciar com numero
//não utilizar acentos
//não utilizar espaços
//camelCase  lastName  (paremetros dentro de metodos, variaveis dentro de metodos)
//PascalCase   LastName = (namespaces, classes, properties e metodos
//padrão   _lastName (atributos internos das classes)


//Writeline (inclui uma quebra de linha
//write (mesma linha)