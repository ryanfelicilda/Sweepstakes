using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Contestant> stack = new Stack<Contestant>();
        public void InsertSweepstakes()
        {
            stack.Pop();
        }
        public void GetSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Pop();
        }
    }
}
