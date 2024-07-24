// lendo valores no teclado

using System; 

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, soma; 
            string nome; 

            Console.Write("\nDigite seu nome: ");
            nome = Console.ReadLine();

            Console.Write(nome);

            Console.WriteLine("\n---------------------");
            Console.Write("Digite um valor: ");
            v1 = int.Parse(Console.ReadLine());

            Console.Write("Digite mais um valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            soma = v1 + v2; 

            Console.WriteLine($"\nA soma de {v1} + {v2} é {soma}");
        }
    }
}