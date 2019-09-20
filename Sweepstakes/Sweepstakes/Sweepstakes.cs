using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        private readonly Dictionary<int, Contestant> contestants;
        public int registrationNumber;
        public string nameOfSweepstake;
        public Sweepstakes(string name)
        {
            nameOfSweepstake = name;
            contestants = new Dictionary<int, Contestant>();
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
        public string PrintContestantInfo(Contestant contestant)
        {
            return contestant.firstName + " " + contestant.lastName + ", " + contestant.emailAdd;
        }
    }
}
