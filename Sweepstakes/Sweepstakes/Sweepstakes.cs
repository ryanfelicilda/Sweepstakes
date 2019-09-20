using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        private readonly Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public int registrationNumber;
        public string nameOfSweepstake;
        public Sweepstakes(string name)
        {
            nameOfSweepstake = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            registrationNumber = contestants.Count() + 1;
            contestants.Add(registrationNumber, contestant);
        }
        public string PickWinner(Contestant contestant)
        {
            return contestant.firstName + " " + contestant.lastName;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + " " + contestant.lastName + ", " + contestant.emailAdd);
        }
    }
}
