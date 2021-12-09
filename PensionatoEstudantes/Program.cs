using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionatoEstudantes
{
    class Program
    {
        static void Main(string[] args)
        {

            string nomeEstudante = string.Empty;
            string emailEstudante = string.Empty;
            int numeroDeQuartosAlugados = 0;
            int numeroDoQuarto = 0;

            Console.WriteLine("Quantos quartos serão alugados?");
            numeroDeQuartosAlugados = int.Parse(Console.ReadLine());

            Estudante[] quartos = new Estudante[10];

            for (int i = 0; i < numeroDeQuartosAlugados; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.WriteLine("Nome do estudante:");
                nomeEstudante = Console.ReadLine();
                Console.WriteLine("E-mail do estudante:");
                emailEstudante = Console.ReadLine();
                Console.WriteLine("Número do quarto:");
                numeroDoQuarto = int.Parse(Console.ReadLine());

                quartos[numeroDoQuarto] = new Estudante(nomeEstudante, emailEstudante);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i].Nome}, {quartos[i].Email}");
                }
            }

            Console.Read();

        }
    }
}
