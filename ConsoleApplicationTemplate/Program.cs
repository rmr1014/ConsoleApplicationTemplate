using System;

namespace ConsoleApplicationTemplate
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = typeof(Program).Name;

            Run();
        }

        private static void Run()
        {
            while (true)
            {
                var consoleInput = ReadFromConsole();

                if (string.IsNullOrWhiteSpace(consoleInput))
                    continue;

                try
                {
                    string result = Execute(consoleInput);

                    WriteToConsole(result);
                }
                catch (Exception ex)
                {
                    WriteToConsole(ex.Message);
                }
            }
        }

        public static void WriteToConsole(string message = "")
        {
            if (message.Length > 0)
                Console.WriteLine(message);
        }

        private static string Execute(string command)
        {
            return string.Format($"Executed the {command} Command");
        }

        private const string _readPrompt = "console> ";

        public static string ReadFromConsole(string promptMessage = "")
        {
            Console.WriteLine(_readPrompt + promptMessage);

            return Console.ReadLine();
        }
    }
}
