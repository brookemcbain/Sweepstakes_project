using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm : ISweepstakesManager
    {
        ISweepstakesManager newSweepstakes; 
        public MarketingFirm(ISweepstakesManager newSweepstakes)
        {
            this.newSweepstakes = newSweepstakes; 
            Sweepstakes sweepstakes = new Sweepstakes("");
            Contestant contestant = new Contestant(); 
            
            sweepstakes.RegisterContestant(contestant);       

        }
        public void GetSweepstakes()
        {
            newSweepstakes.GetSweepstakes(); 
        }
    }
}
