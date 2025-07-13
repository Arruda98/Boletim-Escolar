using System;

namespace Atividade7
{
    class Boletim
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==== Boletim Escolar ====\n");

            Console.WriteLine("Me informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            double notaUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double notaDois = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double notaTres = double.Parse(Console.ReadLine());

            double media = (notaUm + notaDois + notaTres) / 3;

            Console.WriteLine($"A média de {nome} é {media:F2}");

            if (media >= 6)
                Console.WriteLine("Situação: Aprovado!");
            else if (media >= 5)
                Console.WriteLine("Situação: Recuperação!");
            else
                Console.WriteLine("Situação: Reprovado!");
        }
    }
}