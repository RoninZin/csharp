namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, mediaF;

            Console.WriteLine("Digite a 1° nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a 2° nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a 3° nota: ");
            nota3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a 4° nota: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            mediaF = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"A média final é: {mediaF:F1}");
        }
    }
}