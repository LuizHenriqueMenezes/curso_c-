using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha = 'w';

            do
            {
                Console.WriteLine("\nBH/MG a Vitória/ES");
                Console.WriteLine("Escolha o transporte: \n[a] avião \n[b] carro \n[c] ônibus");
                escolha = char.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 'a':
                        tempo = 50;
                        break;
                    case 'b':
                        tempo = 480;
                        break;
                    case 'c':
                        tempo = 660;
                        break;
                    default:
                        tempo = -1;
                        break;
                }

                if (tempo < 0)
                {
                    Console.WriteLine("\nFilhão escolhe direito");
                }
            } while(escolha != 'a' && escolha != 'b' && escolha != 'c');

            Console.WriteLine($"\nVai demorar {tempo} minutos pra você chegar. ");
        }
    }
}
