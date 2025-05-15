namespace vetorrr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Digite 10 números para ordenar:!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o número {i+1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vetor original:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
                
            }


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Vetor ordenado em ordem crescente:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}

