//Se

int month = 2;
string monthName;

if (month == 1)
    monthName = "January";
else if (month == 2)
    monthName = "February";
else if (month == 3)
    monthName = "March";
else
    monthName = "Unknown";


//Escolha

switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:
        monthName = "March";
        break;
    default:
        monthName = "Unknown";
        break;
}
Console.WriteLine($"The month is {monthName}");

/* quando usar if e quando usar swith?
 if:
multiplas condições
quando a condição puder mudar durante o tempo de execução


switch:
meses