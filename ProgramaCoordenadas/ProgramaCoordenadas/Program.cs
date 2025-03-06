using System;



/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escrava a coordenda X: ");
            int coordenadaX = int.Parse(Console.ReadLine());
            Console.WriteLine("Escrava a coordenda Y: ");
            int coordenadaY = int.Parse(Console.ReadLine());

            while (coordenadaX !=0 && coordenadaY !=0)
            {

              if (coordenadaX > 0 && coordenadaY > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }

                else if (coordenadaX < 0 && coordenadaY > 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                else if (coordenadaX > 0 && coordenadaY < 0) 

                {
                    Console.WriteLine("Quarto quadrante");
                }
                else if (coordenadaX < 0 && coordenadaY <0 )
                {
                    Console.WriteLine("Terceiro quadrante");
                }


                Console.WriteLine("Escrava a coordenda X: ");
                coordenadaX = int.Parse(Console.ReadLine());
                Console.WriteLine("Escrava a coordenda Y: ");
                coordenadaY = int.Parse(Console.ReadLine());
            }

            
        }
    }
}