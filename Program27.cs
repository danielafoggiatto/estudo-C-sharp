namespace nota_e_média
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            

            //começa aqui
            int numeroDeAlunos = 0;

            Console.WriteLine("Quantos alunos?");
            numeroDeAlunos = int.Parse(Console.ReadLine());

            double somaTurma = 0;

            for (int i = 1; i <= numeroDeAlunos; i++)
            {
                Console.WriteLine($"Nome do {i}º Aluno: ");
                string nomeDoAluno = Console.ReadLine();

                double somaNota = 0;

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"Digite a {j}ª nota: ");
                    double nota = double.Parse(Console.ReadLine());
                    somaNota += nota;
                }

                double mediaDoAluno = somaNota / 3;
                Console.WriteLine($"A média do aluno {nomeDoAluno} é: {mediaDoAluno}");
                somaTurma += somaNota;

            }
            double mediaDaTurma = somaTurma / numeroDeAlunos;
            Console.WriteLine($"A média da turma é {mediaDaTurma}");


        }

        
        
            
        
    }
}
