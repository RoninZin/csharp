namespace Exe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.WriteLine("Digite a 1° palavra: ");
            palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a 2° palavra: ");
            palavra2 = Console.ReadLine();

            Console.WriteLine("Digite a 3° palavra: ");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                // Verificação se é vertebrado ou invertebrado
                if (palavra1.Equals("vertebrado"))
                {
                    /* Verificando se é ave ou mamífero */
                    if (palavra2.Equals("ave"))
                    {
                        // Verificação se é Águia ou Pombo
                        if (palavra3.Equals("carnivoro"))
                        {
                            Console.WriteLine("Águia");
                        }
                        else
                        {
                            Console.WriteLine("Pomba");
                        }
                    }
                    else
                    {
                        if (palavra3.Equals("onivoro"))
                        {
                            Console.WriteLine("Homem");
                        }
                        else
                        {
                            Console.WriteLine("Vaca");
                        }
                    }
                }
                else
                {
                    if (palavra2.Equals("inseto"))
                    {
                        // Verificação se é Águia ou Pombo
                        if (palavra3.Equals("hematofogo"))
                        {
                            Console.WriteLine("Pulga");
                        }
                        else
                        {
                            Console.WriteLine("Lagarta");
                        }
                    }
                    else
                    {
                        if (palavra3.Equals("hematofogo"))
                        {
                            Console.WriteLine("Sanguessuga");
                        }
                        else
                        {
                            Console.WriteLine("Minhoca");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("As palavras não podem ser nulas!");

            }
        }
    }
}