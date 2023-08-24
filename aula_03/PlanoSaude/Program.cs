using System;

namespace PlanoSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome; //esse ? é pra informar que essa variável pode ser nula
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"\nOlá {nome}. Seja bem vinde!");

            Console.WriteLine("\nDigite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 0 && idade <= 10) {
                Console.WriteLine("\nA mensalidade do plano é de R$ 100,00");
            }
            else if (idade>10 && idade <= 29){
                Console.WriteLine("\nA mensalidade do plano é de R$ 200,00");
            }
            else if (idade > 29 && idade <= 45)
            {
                Console.WriteLine("\nA mensalidade do plano é de R$ 300,00");
            }
            else if (idade > 45 && idade <= 59)
            {
                Console.WriteLine("\nA mensalidade do plano é de R$ 500,00");
            }
            else if (idade > 59 && idade <= 65)
            {
                Console.WriteLine("\nA mensalidade do plano é de R$ 600,00");
            }
            else
            {
                Console.WriteLine("\nA mensalidade do plano é de R$ 1000,00");
            }
        }
    }
}