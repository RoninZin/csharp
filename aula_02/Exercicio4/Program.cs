namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, diff;

            Console.WriteLine("Digite n1: ");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite n2: ");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite n3: ");
            n3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite n4: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            diff = (n1 * n2) - (n3 * n4);
            Console.WriteLine($"A diferença do produto entre as variáveis n1 e n2 pelo produto entre as variáveis n3 e n4 é: {diff}");
        }
    }
}