namespace matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            int a = 0;
            int b = 0;
            int somaLinha4 = 0;
            int somaColuna2 = 0;
            int somaSecundaria = 0;
            int somaTotal = 0;
            int somaDiagonal = 0;

            for (a = 0; a < 5; a++)
            {
                for (b = 0; b < 5; b++)
                {
                    Console.WriteLine($"Digite o valor da posição {a + 1},{b + 1}: ");
                    matriz[a, b] = int.Parse(Console.ReadLine());
                    
                }
            }
            Console.WriteLine();
            for (a = 0; a < 5; a++)
            {
                for (b = 0; b < 5; b++)
                {
                    Console.Write($"{matriz[a, b], 5}");
                }
                Console.WriteLine();
            }
            
            for (b = 0; b < 5; b++)
            {
                somaLinha4 += matriz[3, b];
            }

            for (a = 0; a < 5; a++)
            {
                somaColuna2 += matriz[a, 1];
                somaSecundaria += matriz[a, 5 - a - 1];
            }

            for (a = 0; a < 5; a++)
            {
                for (b = 0; b < 5; b++)
                {
                    if (a == b)
                    {
                        somaDiagonal += matriz[a, b];
                    }
                    somaTotal += matriz[a, b];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"A soma da linha 4 é {somaLinha4}");
            Console.WriteLine($"A soma da coluna 2 é {somaColuna2}");
            Console.WriteLine($"A soma da Diagonal principal é {somaDiagonal}");
            Console.WriteLine($"A soma da Diagonal secundária é {somaSecundaria}");
            Console.WriteLine($"A soma total é {somaTotal}");
        }

    }
}

