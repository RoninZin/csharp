namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, divisao;

            Console.WriteLine("Digite o 1° número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o 2° número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            divisao = numero1 / numero2;

            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));
            Console.WriteLine($"{numero1} / {numero2} = {(numero1 / numero2):F2}");
            Console.WriteLine("{0:F} / {1:F} = {2:F2}" ,numero1 , numero2,divisao);
            Console.WriteLine(Math.Round(divisao, 2));
            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1, numero2));
            Console.WriteLine($"Raiz quadrada de {numero1} = " + Math.Sqrt(numero1));


        }
    }
}