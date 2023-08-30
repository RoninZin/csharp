namespace Atv02Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();
            int opcao;
            string titulo;

            Console.WriteLine("******************************************************\n");
            Console.WriteLine("            1 - Adicionar Livro na pilha");
            Console.WriteLine("            2 - Listar todos os Livros");
            Console.WriteLine("            3 - Retirar Livro da pilha");
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
                    titulo = Console.ReadLine();
                    pilha.Push(titulo);

                    Console.WriteLine("\nPilha: \n");

                    foreach (var addTitulo in pilha)
                    {
                        Console.WriteLine(addTitulo);
                    }

                    Console.WriteLine("\nLivro Adicionado!");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\nLista de Livros na Pilha: \n");

                    foreach (var addTitulo in pilha)
                    {
                        Console.WriteLine(addTitulo);
                    }
                }

                else if (opcao == 3)
                {

                    if (pilha.Count != 0)
                    {
                        Console.WriteLine("\nPilha: \n");

                        pilha.Pop();

                        foreach (var addTitulo in pilha)
                        {
                            Console.WriteLine(addTitulo);
                        }

                        Console.WriteLine("\nUm Livro foi retirado da pilha!\n");

                    }
                    else
                        Console.WriteLine("\nA Pilha está vazia!");
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