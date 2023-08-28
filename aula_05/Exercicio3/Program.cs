namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    Console.Write($"matriz[{indiceLinha} , {indiceColuna}] = ");
                    matriz[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Elementos da Diagonal Principal: {matriz[0, 0]}, {matriz[1, 1]}, {matriz[2, 2]}");

            Console.WriteLine($"\nElementos da Diagonal Secundária: {matriz[0, 2]}, {matriz[1, 1]}, {matriz[2, 0]}");

            Console.WriteLine($"\nSoma dos Elementos da Diagonal Principal: "+ (matriz[0, 0]+matriz[1, 1]+matriz[2, 2]));

            Console.WriteLine($"\nSoma dos Elementos da Diagonal Principal: " + (matriz[0, 2] + matriz[1, 1] + matriz[2, 0]));

        }
    }
}