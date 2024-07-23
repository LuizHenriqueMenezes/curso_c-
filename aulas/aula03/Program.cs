// Váriaveis

using System; 

namespace Aula03 
{
    class Program 
    {
        static void Main(string[] args)
        {
            int num = 2;
            char letra = 'L'; // só letra
            float valor = 1.4f; // tem que ter o f no final pra ficar relacionado com o padrão de float
            byte n = 8; // só cabe 8bits, entre 0 e 255
            string frase = "saudades python";

            var aux = 10; // var não tem tipo especifico, ele é defino na compilação

            Console.WriteLine(frase); 
        }
    }
}

