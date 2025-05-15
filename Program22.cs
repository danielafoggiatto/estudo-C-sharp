namespace leitura_e_calculo
{
    internal class Program
    {
        static int tamanho = 0;
        static int[] vetor = new int[11];

        static void Inserir()
        {
            
            if(tamanho < 10)
            {
                Console.WriteLine("Digite o valor a ser inserido: ");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor inserido com sucesso!");
            }

            Console.WriteLine("Escrever mais um valor?");
            Console.WriteLine("[1]SIM  [2]NÃO");
            int resposta = int.Parse(Console.ReadLine());
            while(resposta == 1)
            {
                Inserir();
            }
            Main();
        }

        static void Remover()
        {
            if(tamanho > 0)
            {
                Console.WriteLine($"Digite a posição do valor a ser removido (1 a {tamanho}): ");
                int position = int.Parse(Console.ReadLine());
                if(position >=1 && position <= tamanho)
                {
                    position--;

                    for (int i = position; i < tamanho; i++)
                    {
                        vetor[i] = vetor[i+ 1];
                    }
                    vetor[tamanho -1] = 0;
                    tamanho--;
                    Console.WriteLine("Valor removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Posição inválida!");
                }
            }

            else
            {
                Console.WriteLine("O vetor está vazio!");
            }
        }

        static void EscreverVetor()
        {
            if(tamanho > 0)
            {
                Console.WriteLine("Vetor atual:");
                for (int i = 1; i < tamanho; i++)
                {
                    Console.WriteLine($"{vetor[i]}   ");
                }
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("O vetor está vazio!");
            }
        }
        static void Main()
        {
            
            for (int i = 1; i <= 10; i++)
            {
                vetor[i] = 0;
            }

            Console.WriteLine("MENU DE OPÇÕES:");
            Console.WriteLine("[1] Inserir");
            Console.WriteLine("[2] Remover");
            Console.WriteLine("[3] Escrever o Vetor na Tela"); 
            Console.WriteLine("[4] Sair");
            int option = int.Parse(Console.ReadLine());

            while(option != 4)
            {
                switch (option)
                {
                    case 1:
                        Inserir();
                        break;
                    case 2:
                        Remover();
                        break;
                    case 3:
                        EscreverVetor();
                        break;
                }
            }
           

        }
    }
}
