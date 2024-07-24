/* Operações de Bitwise
<< Dobrar
>> Metade 
exemplo 10 = 00001010, se dobrar (>>):
00010100 = 20, vai passando uma cada pra esquerda pra dobrar, 
e pra direita pra dividir 

é possível fazer bitwise de números além de 1, 
por exemplo 2, que muda 2 casas pra esqueda ou direita
*/

using System; 

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10; 

            num = num << 1; 

            Console.WriteLine(num);
        }
    }
}