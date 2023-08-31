namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Ana Julia", 23, "Rua Generation, 03", "Dell Vostro15 - i7", 8299.99M);
            Cliente cliente2 = new Cliente("Hajime Isayama", 37, "Rua Maria, 1", "Folhas de rascunho", 249.99M);

            Console.WriteLine("Histórico:\n");
            cliente1.Visualizar();
            Console.WriteLine();
            cliente2.Visualizar();

        }
    }
}