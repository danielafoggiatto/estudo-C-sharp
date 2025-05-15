using System.Drawing;

namespace ConsoleApp51
{

    public struct Event
    {
        public DateTime StarDate { get; }
        public DateTime EndDate { get; }

        public Event(DateTime starDate, DateTime endDate)
        {
            StarDate = starDate;
            EndDate = endDate;
        }

        public double GetDuration()
        {
            return (EndDate - StarDate).TotalDays;
        }

    }


   

    internal class Program
    {
        static void EnterBirth()
        {
            PrintColor(ConsoleColor.DarkCyan, "Qual sua data de nascimento? (Formato: dd/mm/yyyy)");
            string input = Console.ReadLine();
            DateTime nascimento;

            if (DateTime.TryParse(input, out nascimento))
            {
                Event event1 = new Event(nascimento, DateTime.Today);
                PrintColor(ConsoleColor.DarkMagenta, $"Já vivi {event1.GetDuration()} dias");
                Console.WriteLine();
            }
            else
            {             
                PrintColor(ConsoleColor.DarkRed, "Formato inválido. Tente novamente e coloque o dia, mês e ano de seu nascimento:");
                EnterBirth();
            }
        }


        static void Main(string[] args)
        {
            EnterBirth();

            Console.ReadKey();
            
        }
        public static void PrintColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

       
    }
}



