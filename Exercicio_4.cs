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
            fatEmpresa();
        }
        static void fatEmpresa()
        {
            double sp = 67836.43d,
                rj = 36678.66d,
                mg = 29229.88d,
                es = 27165.48d,
                anot = 19849.53d,
                total = ((double) (sp + rj + mg + es + anot)),
                porc_sp = (Math.Round((double)(sp * 100) / total)),
                porc_rj = (Math.Round((double)(rj * 100) / total)),
                porc_mg = (Math.Round((double)(mg * 100) / total)),
                porc_es = (Math.Round((double)(es * 100) / total)),
                porc_anot = (Math.Round((double)(anot * 100) / total));
            Console.WriteLine(total);
            Console.WriteLine($"A porcentagem do valor mensal de São Paulo para a distribuidora foi de aproximadamente {porc_sp}%");
            Console.WriteLine($"A porcentagem do valor mensal do Rio de Janeiro para a distribuidora foi de aproximadamente {porc_rj}%");
            Console.WriteLine($"A porcentagem do valor mensal de Minas Gerais para a distribuidora foi de aproximadamente {porc_mg}%");
            Console.WriteLine($"A porcentagem do valor mensal de Espirito Santo para a distribuidora foi de aproximadamente {porc_es}%");
            Console.WriteLine($"A porcentagem do valor mensal dos outros estados para a distribuidora foi de aproximadamente {porc_anot}%");
            Console.ReadLine();
        }
    }
}
