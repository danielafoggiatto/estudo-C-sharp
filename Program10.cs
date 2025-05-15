namespace ConsoleApp36
{

    /*
    pedir quantos numeros quer
    colocar quais numeros quer em uma lista
    fazer o programa para soma
    programa media
    imprimir os resultados

    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números você quer?");
            int quantidadeDeNumeros = int.Parse(Console.ReadLine());

            var listaDeNumeros = DeclararNumeros(quantidadeDeNumeros);

            Console.WriteLine($"A soma entre os números é {Soma(listaDeNumeros)} e a média é {Media(listaDeNumeros)}");

        }

        static List<decimal> DeclararNumeros(int quantidadeDeNumeros)
        {
            List<decimal> listaDeNumeros = new List<decimal>(quantidadeDeNumeros);
            for (int i = 0; i<quantidadeDeNumeros; i++)
			{
                Console.WriteLine($"Digite o valor para o {i + 1}º número: ");
                listaDeNumeros.Add(decimal.Parse(Console.ReadLine()));
            }
            return listaDeNumeros;
        }

        static decimal Soma(List<decimal> listaDeNumeros)
        {
            decimal soma = 0;
            foreach (decimal numeros in listaDeNumeros)
            {
                soma += numeros;
            }
            return soma;
        }

        static decimal Media(List<decimal> listaDeNumeros)
        {
            decimal soma = Soma(listaDeNumeros);
            decimal media = soma / listaDeNumeros.Count;
            return media;
          
        }
    }
}
