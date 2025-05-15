namespace ConsoleApp27
{
    internal class Program
    {
        //pode colocar todas as variaveis aqui
        //field or instance variable. Ex:
        int myResult;
        //não precisa definir a variavel como int abaixo


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            WriteSomethingSpecific("Danification");
            string myUserName = "Daniela";
            WriteSomethingSpecific(myUserName);
             
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            int myResult = AddTwoValues(num1, 25);
            Console.WriteLine("The result is " + myResult);
        }

        static void WriteSomethingSpecific(string myString)
        {
            Console.WriteLine("You passed this argument to me " + myString);
        }
        
        static int AddTwoValues(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }
        //usando o static não precisa criar um programa dentro do main 
        //para corelacionar o metodo com o main
    }
}
