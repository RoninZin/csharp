namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> teste = new List<double>();

            teste.Add(7.0);
            teste.Add(5.0);
            teste.Add(4.0);
            teste.Add(7.0);
            teste.Add(10.0);

            foreach (double nota in teste)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine("Posição nota 4.0: " + teste.IndexOf(4.0));

            Console.WriteLine("A nota 4.0 existe?" + teste.Contains(4.0));

            teste.Remove(4.0);
        }
    }
}