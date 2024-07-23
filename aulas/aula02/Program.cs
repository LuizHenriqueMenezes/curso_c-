// comando pra criar tudo: 
// - entrar na pasta da aula
// - dotnet new console 

using System; // pra usar as funções básicas

namespace Aula02 // pra organizar
{
    class Program // c# é todo poo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(args.GetValue(0));
        }
    }
}

