﻿namespace ConsoleApp44
{

    public interface ILogger
    {
        void Log(string message);
    }


    public class FileLogger: ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");
            

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message + "\n");

        }
    }

    public class DatabaseLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to database. {message}");
        }
    }


    public class Application
    {
        private readonly ILogger logger;
        public Application(ILogger logger)
        {
            this.logger = logger;
        }

        public void DoWork()
        {
            logger.Log("Work started");
            logger.Log("WORK DONE!");
        }
    }

    internal class Program 
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger dbLogger = new DatabaseLogger();
            app = new Application(dbLogger);
            app.DoWork();


            Console.ReadKey();
        }
    }
}
