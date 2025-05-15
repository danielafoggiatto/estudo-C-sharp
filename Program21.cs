using System.Threading.Channels;

namespace função_par_ou_impar
{
    internal class Program
    {
        static string ParOuImpar(int v)
        {

            if (v % 2 == 0)
            {
                return "PAR";
            }
            else
                return "IMPAR";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            string resultado = ParOuImpar(numero);
            Console.WriteLine($"O número {numero} é {resultado}");
        }
    }
}

