using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Relógio digital Thiesen 1.0");
            Console.Write("Qual o horario atual?: ");
            int hora = Convert.ToInt32(Console.ReadLine());

            if (hora >= 5 && hora <= 12)
            {
                Console.WriteLine("Bom dia!!!");
            }
            else if (hora >= 13 && hora < 18)
            {
                Console.WriteLine("Boa tarde!!!");
            }
            else if (hora >= 18 && hora <= 23 && hora >= 0 && hora <= 4)
            {
                Console.WriteLine("Boa noite!!!");
            }
            Console.ReadKey();
        }
    }
}
