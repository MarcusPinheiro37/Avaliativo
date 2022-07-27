using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();
        }
        static void Fibonacci()
        {
            Inicio:
            Console.WriteLine("Insira um número para checar se ele está na sequência de Fibonacci");
            int a = 0, fibo = 1, num = int.Parse(Console.ReadLine()), atual = 0;
            
            while (fibo <= num)
            {
                Console.Write(a + " " + fibo + " ");
                a = a + fibo;
                fibo = fibo + a;
                atual = fibo - a;
            }
            if (num == atual)
            {
                Console.WriteLine($"\nO número {num} está presente na sequência de Fibonacci");
            }
            else
            {
                Console.Write(fibo);
                Console.WriteLine($"\nO número {num} nâo está presente na sequência de Fibonacci");    
            }
            Console.ReadLine();
            goto Inicio;
        }
    }
}
