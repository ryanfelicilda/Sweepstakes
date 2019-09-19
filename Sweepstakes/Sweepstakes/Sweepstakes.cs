using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //Dictionary<int, Contestant> contDict = new Dictionary<int, Contestant>();
        public Sweepstakes(string name)
        {
            // do stuff;
        }
        public void RegisterContestant(Contestant contestant)
        {
            // do stuff;
        }
        public string PickWinner(Contestant contestant)
        {
            return contestant.firstName + " " + contestant.lastName;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            // do stuff;
        }
    }
}
