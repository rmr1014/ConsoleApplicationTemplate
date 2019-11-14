using System;

namespace ConsoleApplicationBase.Commands
{
    public static class DefaultCommands
    {
        public static string DoSomething(int id, string data)
        {
            return string.Format($"I did something to the record Id {id} and save the data {data}");
        }

        public static string DoSomethingElse(DateTime date)
        {
            return string.Format($"I did something else on {date}");
        }

        public static string DOSomethingOptional(int id, string data = "No Data provided")
        {
            var result = string.Format($"I did something to the record Id {id} and save the data '{data}'");

            if (data == "No Data provided")
                result = string.Format($"I did something to the record Id {id} but the optional parameter was not provided, so I saved the value '{data}'");

            return result;
        }
    }
}
