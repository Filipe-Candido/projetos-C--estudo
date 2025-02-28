using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;   
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

        
           double n4 = (double)10.0 / 8; // pode ser realizar o casting adicionando double ou . com 0

            Console.WriteLine(n4);



            //Representando formula de bascara

            double a = 1, b = -3.0, c = -4.0;
            
            double delta = Math.Pow(b, 2.0) -4.0 * a * c;  // math.pow potencialização

            double x1 = ( -b + Math.Sqrt(delta)) / (2.0 *a); //math.sqrt raiz quadrada
            Console.WriteLine(delta);
            Console.WriteLine(x1);








        }
    }
}