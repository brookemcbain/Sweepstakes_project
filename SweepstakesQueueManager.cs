using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queueSweepstakes;
         
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queueSweepstakes = new Queue<Sweepstakes>();


        }
        public Sweepstakes GetSweepstakes()
        {

            return queueSweepstakes.Dequeue();  
            
        }
    }
}
