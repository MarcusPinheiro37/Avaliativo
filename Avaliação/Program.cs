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
            Reversor();
        }
        static void Reversor()
        {
            Inicio:
            Console.Write("Insira o texto a ser invertido: ");
            string texto = Console.ReadLine(),
                resultado = new String((new Stack<char>(texto)).ToArray());
            Console.WriteLine("Assim fica o texto invertido: " + resultado);
            goto Inicio;
        }
    }
}
