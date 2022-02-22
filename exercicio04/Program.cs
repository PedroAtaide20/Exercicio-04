using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            int negativos = 0, positivos = 0;
            int media = 0;
            int soma = 0;

            for (int i = 1; i < valores.Length; i++)
            {
                Console.Write("Digite o " + i + "º valor: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());

                soma = soma + valores[i];
                media = soma / valores.Length;

                if (valores[i] < 0)
                {
                    negativos++;
                }
                else
                {
                    positivos++;
                }
            }
            Console.WriteLine("\nA média é: " + media);
            Console.WriteLine("valores positivos: " + positivos);
            Console.WriteLine("valores negativos: " + negativos);
            Console.ReadKey();
        }
    }
}
