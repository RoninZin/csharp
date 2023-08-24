namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            float salario, reajuste;
            int cargo;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("\n1 - Supervisor");
            Console.WriteLine("\n2 - Diretor");
            Console.WriteLine("\n3 - Gerente");
            Console.WriteLine("\n4 - Outros");

            Console.WriteLine("Informe o seu cargo(1 a 4): ");
            cargo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nInforme o seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 0.07F);
                    break;
                case 2:
                    reajuste = (salario * 0.09F);
                    break;
                case 3:
                    reajuste = (salario * 0.05F);
                    break;
                default:
                    reajuste = (salario * 0.12F);
                    break;
            }
            Console.WriteLine($"\nO reajuste do salário do(a) {nome} é de: {reajuste}");
            Console.WriteLine($"\nO novo salário é de: {salario+reajuste}");


        }
    }
}