// Enumeradores 

using System; 

namespace Aula10
{
    class Program
    {
        // dentro são os valores possíveis 
        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}; 
        static void Main(string[] args)
        {
            // ele vai receber um valor apenas que for possível 
            DiasSemana ds = DiasSemana.Domingo;

            // pega o indice e manda pra uma váriavel int
            int x = (int)DiasSemana.Sexta;

            Console.WriteLine(ds);
            Console.WriteLine(x);
        }
    }
}