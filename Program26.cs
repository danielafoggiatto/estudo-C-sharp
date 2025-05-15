namespace matriz_menor_valor
{
    internal class Program
    {
        static int[,] matrizDaniela = new int[3, 3];
        static int a = 0;
        static int b = 0;


        static void MenorValor()
        {
            int menorValor = matrizDaniela[1, 1];
            int positionA = 1;
            int positionB = 1;

            for (a = 0; a < 3; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    if (matrizDaniela[a, b] < menorValor)
                    {
                        menorValor = matrizDaniela[a, b];
                        positionA = a + 1;
                        positionB = b + 1;
                    }
                }
            }
            Console.WriteLine($"O menor valor da matriz é {menorValor} na posição {positionA},{positionB}");
        }


        static void Main(string[] args)
        {
           

            for (a = 0; a < 3; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    Console.WriteLine($"Digite o número para a posição {a+1},{b+1}: ");
                    matrizDaniela[a, b] = int.Parse(Console.ReadLine());
                }
            }
            for (a = 0; a < 3; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    Console.Write($"{matrizDaniela[a, b], 5}");
                }
                Console.WriteLine();
            }


            //MenorValor();
            // NumerosPares();
            

            Console.ReadKey();

        }
       


        static void NumerosPares()
        {
            int totalDePares = 0;
            int totalDeImpares = 0;

            for (a = 0; a < 3; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    if (matrizDaniela[a, b] % 2 == 0)
                    {
                        Console.WriteLine($"Números pares:[{matrizDaniela[a, b]}]");
                        totalDePares++;
                    }
                    if (matrizDaniela[a,b] < 0)
                    {

                    }
                    else {
                        Console.WriteLine($"Números ímpares:[{matrizDaniela[a, b]}]");
                        totalDeImpares++;
                    }
                }
            }
            Console.WriteLine($"Tem {totalDePares} números pares.");
            Console.WriteLine($"Tem {totalDeImpares} números ímpares.");
        }
    }
}
