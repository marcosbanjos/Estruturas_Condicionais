using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIdade
{
    internal class CalculoIdade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("CALCULO DE IDADE");
            Console.WriteLine("----------------\n");

            Console.Write("Insira seu ano de nascimento: ");
            int nasc = Convert.ToInt32(Console.ReadLine());

            int idade = DateTime.Now.Year - nasc;

            Console.WriteLine("Sua idade é: " + idade);
            
            if (idade > 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você não é maior de idade");
            }

            Console.ReadKey();
        }
    }
}
