namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo, saque, deposito;
            int operacao;

            saldo = 1000M;

            Console.WriteLine("Digite o código da operação que seja realizar com base na tabela abaixo:");
            Console.WriteLine("Código da operação: 1 - Visualizar saldo");
            Console.WriteLine("Código da operação: 2 - Realizar saque");
            Console.WriteLine("Código da operação: 3 - Realizar depósito");
            operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1: Console.WriteLine($"\nSeu saldo atual é de R$ {saldo}.");
                    break;
                case 2: Console.WriteLine("\nDigite o valor do saque: ");
                        saque = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine((saque <= 1000 && saque>0) ? $"\nSeu novo saldo é de R$ {saldo-saque}" : "\nSaldo insuficiente!");
                    break;
                case 3: Console.WriteLine("\nDigite o valor do depósito: ");
                        deposito = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"\nSeu novo saldo é de R$ {saldo + deposito}");
                    break;
                default:
                    Console.WriteLine("\nOperação Inválida!");
                    break;
            }




        }
    }
}