

//LOOPS

//FOR
//for (int counter = 0; counter < 10; counter++)
//{
//    Console.WriteLine("Counter is " + counter);
//}
//for em ordem decrescente

//in string \ is an "escape character". Is a new line
// \r - carriege return
//string myString = "Hi \r\nBy";


//for (int counter2 = 10; counter2 >= 0; counter2--)
//{
//    Console.WriteLine("Counter is " + counter2);
//    Console.WriteLine(myString);
//    Thread.Sleep(1000);
//}


//While Loop
//precisa de uma condição para executar o que estiver dentro do loop
//enquanto o while for verdadeiro, vai continuar executando.

//int counter3 = 0;
//while (counter3 < 10)
//{
//    Console.WriteLine(counter3);
//    counter3++;
//    //se nao usar variavel++ entrará em loop infinito
//}

//while com bool
//bool isGood = true;
//while (isGood)
//{
//    Console.WriteLine("Life is Good");
//    isGood = false;
//}

//Console.WriteLine("Enter go or stay");

//string userChoise = Console.ReadLine();

//while (userChoise == "go")
//{
//    Console.WriteLine("Go for a mile");
//    Console.WriteLine("Wanna keep going? Enter go.");
//    userChoise = Console.ReadLine();
//}

Random random = new Random();

int secretNumber = random.Next(1, 101);


//int secretNumber = 42; se não for usado random
int userGuess = 0;
int counter = 0;

Console.WriteLine("Guess the number I'm thinking of between 1 and 100");

while (userGuess != secretNumber)
{
    counter++; 
    Console.WriteLine("Enter your Guess");
    userGuess = int.Parse(Console.ReadLine());
    if(userGuess < secretNumber)
        Console.WriteLine("Too Low, Try again.");
    else if(userGuess > secretNumber)
        Console.WriteLine("Too Hight, Try again.");
    else
        Console.WriteLine("Congratulations! You guessed the number right! It took you " + counter + " tries");


}



Console.ReadKey();

