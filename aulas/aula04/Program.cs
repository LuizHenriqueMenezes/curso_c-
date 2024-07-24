// escopo de váriaveis
// onde a váriavel é visivel, até onde ela pode ser acessada
// por exemplo, se eu coloco uma váriavel no static void Main, eu tenho acesso direto a ela
// se eu coloco no class Program por exemplo, eu não tenho acesso direto a ela

using System; 

namespace Aula04
{
    class Program
    {
        int x = 10; 
        // aqui só da pra usar no static void Main assim:
        static int w = 100; 

        static void Main(string[] args)
        {
           // int num = 0; 
           Console.WriteLine(w);
        }

        void teste(){
           // Console.WriteLine(num); isso não daria certo porque num é uma váriavel local no método main
            Console.WriteLine(x);
        }
    }
}