// formatando a saída no console

using System; 

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3; 

            n1 = 10;
            n2 = 20; 
            n3 = 30; 

            Console.Write($"\nn1 = {n1}, n2 = {n2} e n3 = {n3}\n");

            double vl_compra = 2.54; 
            double lucro = 0.1; 
            Console.WriteLine($"Valor da compra: {vl_compra:c}");
            // esse :c vai automaticamente exibir como vl monetário
            Console.WriteLine($"Quero lucro de: {lucro:p}");
            // :p mostra em porcentagem
        }
    }
} 