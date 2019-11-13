using System;
using System.Linq;
using System.Text;

namespace ConsoleApplicationBase
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
                    var cmd = new ConsoleCommand(consoleInput);
                    string result = Execute(cmd);

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

        private static string Execute(ConsoleCommand command)
        {
            var sb = new StringBuilder();

            sb.AppendFormat($"Executed the {command.LibraryClassName}.{command.Name} Command").AppendLine();

            for (int i = 0; i < command.Arguments.Count(); i++)
            {
                sb.Append(ConsoleFormatting.Indent(4)).AppendFormat($"Argument{i} value: {command.Arguments.ElementAt(i)}").AppendLine();
            }

            return sb.ToString();
        }

        private const string _readPrompt = "console> ";

        public static string ReadFromConsole(string promptMessage = "")
        {
            Console.WriteLine(_readPrompt + promptMessage);

            return Console.ReadLine();
        }
    }
}
