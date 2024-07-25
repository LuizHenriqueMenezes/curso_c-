// if else
using System; 

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota"); 
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if((n1 + n2) / 2 >= 6){
                Console.WriteLine($"\nAprovado com {(n1 + n2) / 2}");
            }else{
                Console.WriteLine($"\nReprovado com {(n1 + n2) / 2}");
            }
        }
    }
}