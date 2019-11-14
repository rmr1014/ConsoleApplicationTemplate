using ConsoleApplicationBase.Models;
using System;
using System.Linq;
using System.Text;

namespace ConsoleApplicationBase.Commands
{
    public static class Users
    {
        public static string Create(string firstName, string lastName)
        {
            int? maxId = SampleData.Users.Max(u => u.Id);

            int newId = 0;

            if (maxId.HasValue)
                newId = maxId.Value + 1;

            var newUser = new User
            {
                Id = newId,
                FirstName = firstName,
                LastName = lastName
            };

            SampleData.Users.Add(newUser);

            return "";
        }

        public static string Get()
        {
            var sb = new StringBuilder();

            foreach (var user in SampleData.Users)
            {
                sb.Append(ConsoleFormatting.Indent(2)).AppendFormat($"Id:{user.Id} {user.FirstName} {user.LastName}").AppendLine();
            }

            return sb.ToString();
        }
    }
}
