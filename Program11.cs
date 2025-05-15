namespace ConsoleApp40
{
    internal class Program
    {
        static double Media(ref double nota1, ref double nota2)
        {
            double media = (nota1 + nota2) / 2;
            return media;
        }
        static void Main(string[] args)
        {
            int[] vetorA = new int[4];
            int[] vetorB = new int[4];
            int[] vetorC = new int[4];
            int[] vetorD = new int[4];

            string nomeDoAluno;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"NOME DO ALUNO {i + 1}: ");
                nomeDoAluno = Console.ReadLine();
                Console.WriteLine("Primeira nota: ");
                double primeiraNota = double.Parse(Console.ReadLine());
                Console.WriteLine("Segunda nota: ");
                double segundaNota = double.Parse(Console.ReadLine());
                double media =  Media(ref primeiraNota, ref segundaNota);
               
                Console.WriteLine($"A média no Aluno {i + 1}, {nomeDoAluno} foi {media}");
            }

        }

        
    }
}


