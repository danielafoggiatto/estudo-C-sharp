using System.Threading.Channels;

int num1 = 0;
int num2 = 0;
int age = 0;

//relational operator < <= > >=

bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("Please, enter a number:");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("The numbers are equal!");

    Console.WriteLine("Please, enter your age:");
    age = int.Parse(Console.ReadLine());
    //a variável age só funciona dentro deste escopo (if)
    //se criar a variável fora desse escopo, não precisa definir a variável novamente como (int): int age = ...
    //aqui atribuiu um valor à variável age antes criada, com valor (0)
    if (age >= 18)
       
    {
        Console.WriteLine("Please, enter your adress, " +
            "so that we can sen you the price:");
        string adress = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry, you can't get your price due to your age.");
    }
        
}
else
{
    Console.WriteLine("The numbers aren't equal!");
}



    /*
    //if else elseif
    int age = 16;
    bool isWithParents = true;

    if(age >= 13 && isWithParents)
    {
        Console.WriteLine("Go party to the club with parents!");
    }

    else if(age > 18)
    {
        Console.WriteLine("Go party in the club");
    }
    else
    {
        Console.WriteLine("Go party in the kindergarten!");
    }

    //O código para de executar assim que encontrar a primeira verdadeira. 
    */

    Console.ReadKey();