namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
            int operacao;

            Console.WriteLine("Código 1 - Operação: SOMA");
            Console.WriteLine("Código 2 - Operação: SUBTRAÇÃO");
            Console.WriteLine("Código 3 - Operação: MULTIPLICAÇÃO");
            Console.WriteLine("Código 4 - Operação: DIVISÃO");

            Console.WriteLine("\nDigite o 1° número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nDigite o 2° número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nDigite o código da operação: ");
            operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1: Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
                    break;
                case 4:
                    Console.WriteLine((numero2!=0)? $"{numero1} / {numero2} = {numero1 / numero2}" : "Divisão por zero!");
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }
        }
    }
}