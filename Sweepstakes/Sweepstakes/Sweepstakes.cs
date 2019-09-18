using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Sweepstakes(string name)
        {
            // do stuff;
        }
        public void RegisterContestant(Contestant contestant)
        {
            // do stuff;
        }
        public Contestant PickWinner(string contestant)
        {
            // do stuff;
            return contestant.firstName + " " + contestant.lastName;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            // do stuff;
        }
    }
}
