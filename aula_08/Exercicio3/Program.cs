namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod1 = new Produto("The Legend of Zelda: Ocarina of Time", 1, 2, 2, 449.99M);
            Produto prod2 = new Produto("SteamDeck", 2, 1, 1, 3499.99M);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     c..........GAME ALL TIME...............");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************************");

            prod1.Visualizar();
            prod2.Visualizar();
            Console.ResetColor();
        }
    }
}