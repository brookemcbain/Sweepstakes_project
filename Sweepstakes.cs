using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public string name;
        Random random;
        Dictionary<int, Contestant> dictContestants;
        


        public Sweepstakes(string name)
        {
            this.name = name;
            dictContestants = new Dictionary<int, Contestant>();
            
        }

        public void RegisterContestant(Contestant contestant)
        {
            int registrationNumber = dictContestants.Count; 
            dictContestants.Add(registrationNumber, contestant); 
   
        }
        public Contestant PickWinner()
        {
            random = new Random();
            int randomContestant = random.Next(dictContestants.Count);
            Contestant winner = dictContestants[randomContestant];  //{ 1, Brooke}, {2, Charles}
            return winner;
            
              
        }
        public void PrintContestantInfo(Contestant contestant, Contestant registrationNumber)
        {


            UserInterface.DisplayContestantInfo(contestant, registrationNumber); 

        }
        
    }
}
