// if
using System; 

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota: ");
            int nota = int.Parse(Console.ReadLine()); 

            if(nota >= 6){
                Console.WriteLine("aprovado :D");
            }
        }
    }
}