namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            bool primDoacao;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primeira doação de sangue?");
            primDoacao = Convert.ToBoolean(Console.ReadLine());

            if (idade >= 18 && idade < 60)
            {
                Console.WriteLine($"{nome} está apto para doar sangue!");
            }
            else if (idade >= 60 && idade <= 69 && primDoacao == false)
            {
                Console.WriteLine($"{nome} está apto para doar sangue!");
            }
            else if (idade >= 60 && idade <= 69 && primDoacao == true)
            {
                Console.WriteLine($"{nome} não está apto para doar sangue!");
            }
            else
            {
                Console.WriteLine($"{nome} não está apto para doar sangue!");
            }
        }
    }
}