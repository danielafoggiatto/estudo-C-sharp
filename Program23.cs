using System.Collections.Generic;

namespace LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = ["red", "green", "blue", "red", "red", "red"];
            Console.WriteLine("Colors in the list!");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            //remove itens da lista. REmove o 1º item com o nome "red".
            //colors.Remove("red");
            //remove todos os itens
            bool isDeletingAll = colors.Remove("red");
            while (isDeletingAll)
            {
                isDeletingAll = colors.Remove("red");
            }


            Console.WriteLine("Colors in the list!");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            List<int> myNumbers = new List<int> { 10, 6, 8, 3, 12, 15, 25 };
            Console.WriteLine("Unsorted list");

            foreach (int number in myNumbers)
            {
                Console.WriteLine(number);
            }

            //classifica a lista
            myNumbers.Sort();
            Console.WriteLine("Sorted lis");
            foreach (int number in myNumbers)
            {
                Console.WriteLine(number);
            }
           
            
            //lambda
            //lista maior que 10.. cria uma nova lista e procura numeros mais que 10 e 
            //o coloca na nova lista
            List<int> higher10 = myNumbers.FindAll(x => x >= 10);
            //é uma simplificação do exemplo abaixo

            //static int Dani(int num1)
            //{
            //    return num1 * num1;
            //}
            Console.WriteLine("Numbers higher 10");
            foreach (int number in higher10)
            {
                Console.WriteLine(number);
            }

            Predicate<int> isGreaterThanTwenty = x => x >= 20;
            List<int> higherEqual20 = myNumbers.FindAll(isGreaterThanTwenty);
            Console.WriteLine("Numbers higher 20");
            foreach (int number in higherEqual20)
            {
                Console.WriteLine(number);
            }
            //expressão lambda é uma maneira curta de criar um método que nunca 
            //será chamado fora do momento que for usado.


            //delegate é um ponto ou referencia para um método, permite vc passar
            //metodos como argumento para outros metodos, armazena em variaveis
            //e chama posteriormente.

            //any method usa um lambda para testar cada n na lista e ver se tem
            //o n na lista

            bool hasLargeNumber = myNumbers.Any(x => x > 25);

            if(hasLargeNumber)
            {
                Console.WriteLine("There are large numbers.");
            }
            else
            {
                Console.WriteLine("No large numbers.");

            }


        }
    }
}
