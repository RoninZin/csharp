namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();
            int numero;

            Console.WriteLine("Você precisará digitar 10 números inteiros.\n");

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                numeros.Add(numero);
            }

            Console.WriteLine("\nListar dados do HashSet:\n");

            foreach (var escolha in numeros)
            {
                Console.WriteLine(escolha);
            }
        }
    }
}