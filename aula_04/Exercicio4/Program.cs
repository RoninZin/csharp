namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media, soma=0, participantes=0;
            int idade, genero, area, backend=0, mCeTFrontend=0, hCeTMobile40Mais=0, nBinFullstack30Menos=0;
            string confirmacao = "S";

            while (confirmacao.Equals("S"))
            {

                Console.WriteLine("\nDigite a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                soma = soma + idade;

                Console.WriteLine("Tabela - Identidade de Gênero");
                Console.WriteLine("1 - Mulher Cis");
                Console.WriteLine("2 - Homem Cis");
                Console.WriteLine("3 - Não Binário");
                Console.WriteLine("4 - Mulher Trans");
                Console.WriteLine("5 - Homem Trans");
                Console.WriteLine("6 - Outros");
                Console.WriteLine("\nDigite o código da identidade de gênero: ");
                genero = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nTabela - Pessoa Desenvolvedora");
                Console.WriteLine("1 - Backend");
                Console.WriteLine("2 - Frontend");
                Console.WriteLine("3 - Mobile");
                Console.WriteLine("4 - FullStack");
                Console.WriteLine("\nDigite o código da área de desenvolvimento: ");
                area = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Deseja continuar a leitura dos dados de um novo colaborador? (S/N)");
                confirmacao = Console.ReadLine().ToUpper();


                if (area == 1)
                    backend++;

                if ((genero == 1 || genero == 4) && area == 2)
                    mCeTFrontend++;

                if (idade > 40 && (genero == 2 || genero == 5) && area == 3)
                    hCeTMobile40Mais++;

                if (idade < 30 && genero == 3 && area == 4)
                    nBinFullstack30Menos++;

                if (confirmacao is not null)
                    participantes++;

            }

            media = soma / participantes;

            Console.WriteLine($"O número de pessoas desenvolvedoras Backend: {backend}");
            Console.WriteLine($"O número de Mulheres Cis e Trans desenvolvedoras Frontend: {mCeTFrontend}");
            Console.WriteLine($"O número de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos: {hCeTMobile40Mais}");
            Console.WriteLine($"O número de Não Binários desenvolvedores FullStack menores de 30 anos: {nBinFullstack30Menos}");
            Console.WriteLine($"O número total de pessoas que responderam à pesquisa: {participantes}");
            Console.WriteLine($"A média de idade das pessoas que responderam à pesquisa: {media}");
        }
    }
}