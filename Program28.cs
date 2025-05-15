namespace ordem_cres_e_desc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção: 1, 2 OU 3: ");
            int opção = int.Parse(Console.ReadLine());

            int auxiliar;
            if (opção == 1)
            {
                if (num1 > num2)
                {
                    auxiliar = num1;
                    num1 = num2;
                    num2 = auxiliar;
                }

                if (num2 > num3)
                {
                    auxiliar = num2;
                    num2 = num3;
                    num3 = auxiliar;
                }

                if (num1 > num2)
                {
                    auxiliar = num1;
                    num1 = num2;
                    num2 = auxiliar;
                }
                Console.WriteLine($"Os números em ordem crescente são: {num1}, {num2}, {num3}");
            }

            if (opção == 2)
            {
                if (num1 < num2)
                {
                    auxiliar = num1;
                    num1 = num2;
                    num2 = auxiliar;
                }

                if (num2 < num3)
                {
                    auxiliar = num2;
                    num2 = num3;
                    num3 = auxiliar;
                }

                if (num1 < num2)
                {
                    auxiliar = num1;
                    num1 = num2;
                    num2 = auxiliar;
                }
                Console.WriteLine($"Os números em ordem decrescente são: {num1}, {num2}, {num3}");
            }

            if (opção == 3)
            {
                if (num1 > num2)
                {
                    auxiliar = num1;
                    num1 = num2;
                    num2 = auxiliar;
                }

                if (num3 > num2)
                {
                    auxiliar = num2;
                    num2 = num3;
                    num3 = auxiliar;
                }

                Console.WriteLine($"A ordem com o maior número no meio é: {num1}, {num2}, {num3}");

            }
        }
    }
}
