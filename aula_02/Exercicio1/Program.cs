namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;

            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

                novoSalario = salario + abono;
            Console.WriteLine($"O novo salário é {novoSalario}");
        }
    }
}