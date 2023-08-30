namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();
            string cor;

            for (int contador=1; contador<=5; contador++)
            {
                Console.Write("Digite uma cor: ");
                cor = Console.ReadLine();
                cores.Add(cor);
            }

            Console.WriteLine("\nListar todas as cores:\n");

            foreach (var escolha in cores)
            {
                Console.WriteLine(escolha);
            }

            cores.Sort();

            Console.WriteLine("\nOrdenar as cores:\n");

            foreach (var escolha in cores)
            {
                Console.WriteLine(escolha);
            }
        }
    }
}