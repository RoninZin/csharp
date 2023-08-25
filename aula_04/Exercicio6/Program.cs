namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float soma = 0, quantidade = 0, numero;

            do
            {
                Console.WriteLine("Digite um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 3 == 0 && numero!=0)
                {
                    quantidade++;
                    soma += numero;
                }

            } while (numero != 0);

                Console.WriteLine($"A média de todos os números múltiplos de 3 é: {soma/quantidade}");
         
        }
    }
}