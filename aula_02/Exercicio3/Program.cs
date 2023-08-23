namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salBruto, addNot, hrExt, desc, salLiq;

            Console.WriteLine("Digite o salário bruto: ");
            salBruto = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor do adicional noturno: ");
            addNot = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o número de horas extras: ");
            hrExt = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor do desconto: ");
            desc = Convert.ToSingle(Console.ReadLine());

            salLiq = salBruto+addNot+(hrExt*5)-desc;
            Console.WriteLine($"O salário líquido é de R$ "+salLiq+" .");
        }
    }
}