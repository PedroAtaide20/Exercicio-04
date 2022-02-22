using System;

namespace ListaExercícios04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura;
            int altura;
            string printe = "";

            Console.WriteLine("Escreva a largura do retangulo: ");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva a altura do retangulo: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                for (int l = 0; l < largura; l++)
                {
                    printe = printe + "*";
                }
                printe += "\n";
            }
            Console.WriteLine(printe);
            Console.ReadKey();
        }
    }
}
