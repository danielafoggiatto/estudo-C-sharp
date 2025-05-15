
//int counter = 0;
//// o loop while-do executa o programa ao menos 1x, mesmo sendo falso
////é feito antes 1x ao menos antes de fazer o teste para ver se é true or false
////post-test loop. Usa-se qdo precisa de entrada do usuario
//do
//{
//    Console.WriteLine(counter);
//    counter++;

//} while (counter <10);
//o while está ao lado do colchetes para indicar se é verdadeiro ou falso.
//enquanto o contador for menor que 10, será verdadeiro e o programa é executado.

//MEDIA CALCULATOR

int currentScore;
int sum =0;
int counter = 0;

do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish!");
    currentScore = int.Parse(Console.ReadLine());
    if(currentScore != -1)
    {
        sum = sum + currentScore;
    }
    counter++;
} while (currentScore != -1);

int average = sum / counter; 

Console.WriteLine("The average is: " + average);

Console.ReadKey();


