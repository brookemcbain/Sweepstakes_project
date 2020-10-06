using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public string name;
        Random random; 
        public Sweepstakes(string name)
        {
            this.name = name; 
        }
        public void RegisterContestant(Contestant contestant)
        {
            
        }
        public Contestant PickWinner()
        {
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayContestantInfo(contestant); 

        }
    }
}
