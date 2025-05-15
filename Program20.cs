
namespace fatorial_com_função
{
    internal class Program
    {
        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtração(int a, int b)
        {
            return a - b;
        }

        static int Multiplicação(int a, int b)
        {
            return a * b;
        }

        static int Divisão(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º n: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º n: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultadoSoma = Soma(num1, num2);
            int resultadoSubtração = Subtração(num1, num2);
            int resultadoMultiplicação = Multiplicação(num1, num2);
            int resultadoDivisão = Divisão(num1, num2);
            Console.WriteLine($"O resultado da soma é {resultadoSoma}");
            Console.WriteLine($"O resultado da subtração é {resultadoSubtração}");
            Console.WriteLine($"O resultado da multiplicação é {resultadoMultiplicação}");
            Console.WriteLine($"O resultado da divisão é {resultadoDivisão}");
        }
    }
}
