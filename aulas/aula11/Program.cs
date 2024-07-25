// Conversões de tipos

using System; 

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            // algumas conversões ja são implicitas
            int n1 = 10; 
            float n2 = n1; 

            Console.WriteLine(n2);

            /* 
            não implicita alerta que não pode converter
            da erro:
            float x = 10.5;
            int y = x; 

            Console.WriteLine(y);
            */

            // fazendo a conversão type cast:

            float x = 10.5f; // quando é float precisa colocar o sufixo f
            int y = (int)x; // eliminou o 0.5 

            Console.WriteLine(y);
            
        }
    }
}