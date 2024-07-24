//Constantes 
//não pode mudar de valor depois que é atribuido 

using System; 

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            const string nome = "Luiz Henrique";
            const int idade = 19; 
            
            Console.Write($"Nome: {nome} // Idade: {idade}");
        }
    }
}