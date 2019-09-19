using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface ISweepstakesManager
    {
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            // do stuff;
        }
        public Sweepstakes GetSweepstakes()
        {
            // do stuff;
        }
    }
}
