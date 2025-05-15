namespace matriz_de_ordem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizOrdem7 = new int[7, 7];
            int i = 0;
            int j = 0;

            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    matrizOrdem7[i, j] = 0;
                }
            }

            int linha = 0;
            int coluna = 3;
            matrizOrdem7[linha, coluna] = 1;

            int num = 2;

            while(num <= 49)
            {
                linha = linha - 1;
                coluna = coluna - 1;
                if(linha < 0)
                {
                    linha = 6;
                }
                if(coluna < 0)
                {
                    coluna = 6;
                }
                if (matrizOrdem7[linha, coluna] == 0)
                {
                    matrizOrdem7[linha, coluna] = num;
                    num++;
                }
                else
                {
                    linha = (linha + 1)%7;
                    matrizOrdem7[linha, coluna] = num;
                    num = num + 1;
                }
            }

            Console.WriteLine("Quadrado Mágico de Ordem 7:");
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write($"{matrizOrdem7[i, j],5}"); 
                }
                Console.WriteLine();
            }
        }
    }
}
