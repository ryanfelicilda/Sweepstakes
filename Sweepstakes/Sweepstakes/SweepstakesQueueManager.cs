using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        private readonly Queue<Contestant> queue = new Queue<Contestant>(); // <Contestant> or <Sweepstakes>
        public void InsertSweepstakes()
        {
            queue.Enqueue(); // Enqueue vs. Dequeue ???
        }
        public void GetSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(); // Enqueue vs. Dequeue ???
        }
    }
}
