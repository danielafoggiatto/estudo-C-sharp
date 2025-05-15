namespace ConsoleApp47
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"File log: {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console");

            logHandler = logger.LogToFile;
            logHandler("Log some stuff");
            

            InvokeSafely(logHandler, "After removing LogToFile");

            //multicast delegate: chama todos os métodos que são add por ordem 
            //e neste caso, vai mostrar a mesma mensagem.
            //logHandler += logger.LogToFile;
        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if(tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }
    }
}
