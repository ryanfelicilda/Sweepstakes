using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        public string UserInput(string customMessage)
        {
            Console.WriteLine(customMessage);
            string input = Console.ReadLine().Trim();
            return input;
        }
        public int UserInput(int customNumber)
        {
            Console.WriteLine(customNumber);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        public void AssignContestantObjects(Contestant contestant)
        {
            contestant.firstName = UserInput("Please enter your first name.");
            contestant.lastName = UserInput("Please enter your last name.");
            contestant.emailAdd = UserInput("Please enter your email address.");
        }
        public int GenerateRegistrationNumber()
        {
            Random random = new Random();
            int number = random.Next(100000, 500000);
            return number;
        }
    }
}
