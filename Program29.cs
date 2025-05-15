namespace total_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura = 0;
            double maiorAltura = altura;
            int pesoTotal = 0;
            int feminino = 0;
            int masculino = 0;
            
            int totalDePessoas = 5;

            for (int i = 1; i <= totalDePessoas; i++)
            {
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Altura:");
                altura = double.Parse(Console.ReadLine());
                if(altura > maiorAltura)
                {
                    maiorAltura += altura;
                }

                Console.WriteLine("Peso:");
                int peso = int.Parse(Console.ReadLine());
                pesoTotal += peso;

                Console.WriteLine("Sexo:");
                Console.WriteLine("[1] Feminino");
                Console.WriteLine("[2] Masculino");
                int sexo = int.Parse(Console.ReadLine());
                if(sexo == 1)
                {
                    feminino++;
                }
                else if (sexo == 2)
                {
                    masculino++;
                }
                else
                {
                    Console.WriteLine("Digite um número válido: [1] para Feminino ou [2] para Masculino.");
                }
                Console.Clear();
            }

            double porcentagemDeMulheres = (feminino / (double)totalDePessoas) * 100;
            double porcentagemDeHomens = (masculino / (double)totalDePessoas) * 100;
            int pesoMedio = pesoTotal / totalDePessoas;

            Console.WriteLine($"A quantidade de mulheres é {feminino}, com porcentagem de {porcentagemDeMulheres}%");
            Console.WriteLine($"A quantidade de homens é {masculino}, com porcentagem de {porcentagemDeHomens}%");
            Console.WriteLine($"O peso médio é {pesoMedio}");
            Console.WriteLine($"A maior altura é {maiorAltura}");
        }
    }
}
