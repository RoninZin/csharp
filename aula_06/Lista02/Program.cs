namespace Lista02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            // adicionar novos elementos
            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            foreach (double nota in notas)
            {
                // listar os elementos
                Console.WriteLine(nota);
            }

            // índice de um elemento
            Console.WriteLine("Posição nota 4.0: " + notas.IndexOf(4.0));

            // checar se o elemento existe
            Console.WriteLine("A nota 4.0 existe?" + notas.Contains(4.0));

            // remover elemento
            notas.Remove(7.0);

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            // índice de um elemento
            Console.WriteLine("Posição nota 10.0: " + notas.IndexOf(10.0));

            // tamanho da lista
            Console.WriteLine("Quantos elementos tem na lista? " + notas.Count);

            // Ordenação crescente
            notas.Sort();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            // Ordenação decrescente
            notas.Reverse();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            // Alteração de nota
            notas[0] = 9.0;

            foreach (var nota in notas) //var cria variáveis do tipo implícito
            {
                Console.WriteLine(nota);
            }
        }
    }
}