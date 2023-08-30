namespace Atv01Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            int opcao;
            string nome;

            Console.WriteLine("******************************************************\n");
            Console.WriteLine("            1 - Adicionar Cliente na Fila");
            Console.WriteLine("            2 - Listar todos os Clientes");
            Console.WriteLine("            3 - Retirar Cliente da Fila");
            Console.WriteLine("            0 - Sair\n");
            Console.WriteLine("******************************************************");
            Console.WriteLine("Entre com a opção desejada: ");

            do
            {
                Console.Write("\nDigite uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("\nDigite o nome: ");
                    nome = Console.ReadLine();
                    fila.Enqueue(nome);

                    Console.WriteLine("\nFila: \n");

                    foreach (var addNome in fila)
                    {
                        Console.WriteLine(addNome);
                    }

                    Console.WriteLine("\nCliente Adicionado!");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\nLista de Clientes na Fila: \n");

                    foreach (var addNome in fila)
                    {
                        Console.WriteLine(addNome);
                    }
                }

                else if (opcao == 3)
                {

                    if (fila.Count != 0)
                    {
                        Console.WriteLine("\nFila: \n");

                        fila.Dequeue();

                        foreach (var addNome in fila)
                    {
                        Console.WriteLine(addNome);
                    }

                    Console.WriteLine("\nO Cliente foi Chamado!\n");

                    }
                    else
                        Console.WriteLine("\nA Fila está vazia!");
                }

            } while (opcao > 0 && opcao <= 3);

            if (opcao == 0)
            {
                Console.WriteLine("\nPrograma Finalizado!");
            }
            else
                Console.WriteLine("\nOPÇÃO INVÁLIDA!");

        }
    }
}