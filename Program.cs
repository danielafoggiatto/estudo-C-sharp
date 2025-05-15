// See https://aka.ms/new-console-template for more information

string question1 = "What is the capital og Germany";
string answer1 = "Berlin";

string question2 = "What is 2 + 2";
string answer2 = "4";

string question3 = "What color o you get by mixing blue and yellow";
string answer3 = "Green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if(userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct");
    score = score + 1;
}
else
    Console.WriteLine("Wrong, the correct answer is: " + answer1);


Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct");
    score = score + 1;
}
else
    Console.WriteLine("Wrong, the correct answer is: " + answer2);


Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct");
    score = score + 1;
    //or score++
}
else
    Console.WriteLine("Wrong, the correct answer is: " + answer3);


Console.WriteLine($"Quiz Completed! Your Final score is: {score}/3");
if(score == 3)
    Console.WriteLine("Excellent! You got all the answer right!");
else if(score > 0)
    Console.WriteLine("GoodJob, but keep learning");
else
    Console.WriteLine("Try again and see if you can get some answer right next time");


Console.ReadKey();