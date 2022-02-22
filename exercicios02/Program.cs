using System;

namespace exercicios02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura;
            int altura;
            string printe = "";

            Console.WriteLine("Digite a largura do seu retangulo: ");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura do mesmo: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                for (int l = 0; l < largura; l++)
                {
                    if (i % 2 == 0)
                    {
                        printe += "A";
                    }
                    else
                    {
                        printe += "B";
                    }
                }
                printe += "\n";
            }
            Console.WriteLine(printe);
            Console.ReadKey();
        }
    }
}
