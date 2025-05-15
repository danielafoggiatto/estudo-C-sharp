
//methods are structure like this
//modifier retunrType Name(parameters){
////code block
////}
void MyFirstMethod()
{
    Console.WriteLine("MyFirstMethod was called");
    Console.WriteLine("Danification");
}
////este método não retorna nada (void) e é sem parâmetros
////Como chamar o método
MyFirstMethod();

Console.WriteLine("This is outside of the method");



void WriteSomething()
{
    Console.WriteLine("I'm writing something");
}

WriteSomething();

void WriteSomethingSpecific(string myString)
{
    Console.WriteLine("You passed this argument to me " + myString);
}

WriteSomethingSpecific("Danification");

//or posso criar uma variável para colocar como referencia no parametro
//quando chama o metodo.

string myUserName = "Daniela";
WriteSomethingSpecific(myUserName); //entre parenteses é o argumento

//metodo com 2 parametros
//quando usar parametros e retornar um valor, precisa indicar o tipo 
//de dados (nao pode ser void) e deve ser o mesmo tipo que o parametro
int AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    //Console.WriteLine("Result is " + result);
    //apenas vai fazer a conta e retornar fora do metodo
    return result;
}
Console.WriteLine("Enter a number:");
int num1 = int.Parse(Console.ReadLine());

int myResult = AddTwoValues(num1, 25);
Console.WriteLine("The result is " + myResult);





Console.ReadKey();