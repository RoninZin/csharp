using System.Numerics;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int numero;

            Console.WriteLine("Digite 10 números inteiros não repetidos: ");

            for (int contador = 0; contador < vetor.Length; contador++)
            {
                vetor[contador] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite o número que você deseja encontrar a posição: ");

            numero = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(vetor, numero) == -1 )
            {
                Console.WriteLine($"O número {numero} não foi encontrado!");
            }
            else
            {
                Console.WriteLine($"O número {numero} está localizado na posição: " + Array.IndexOf(vetor, numero));
            }
           
        }
    }
}