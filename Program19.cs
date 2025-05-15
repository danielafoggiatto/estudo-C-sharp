namespace exercicio
{
    internal class Program
    {
        static int peso = 0;
        static int maiorPeso = peso;
        static string nome;

        static void Main(string[] args)
        {
            InicioDoPrograma();
            string maisPesado = nome;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine($"Digite o peso de {nome} em Kg: ");
                peso = int.Parse(Console.ReadLine());

                if(peso > maiorPeso)
                {
                    maiorPeso = peso;
                    maisPesado = nome;
                }

                InicioDoPrograma();
            }

            InicioDoPrograma();
            Console.WriteLine($"A pessoa com maior peso é {maisPesado} com {maiorPeso} kg.");
        }

        static void InicioDoPrograma()
        {
            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" D E T E C T A D O R  D E  P E S A D O ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Maior peso até agora: {maiorPeso} Kg");
            Console.Clear();
        }
    }


}


