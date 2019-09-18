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
    }
}
