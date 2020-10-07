using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            //SweepstakesQueueManager addQueueSweepstakes = new SweepstakesQueueManager();
            //addQueueSweepstakes.InsertSweepstakes("Money"); 

            //SweepstakesStackManager addStackSweepstakes = new SweepstakesStackManager();

            //Sweepstakes addToDictionary = new Sweepstakes("Money");
            //{
            //    Dictionary<int, string> newDict = new Dictionary<int, string>();
            //    {
            //        newDict.Add(1, "string"); 
            //    }
            //}

            Dictionary<int, string> newDict = new Dictionary<int, string>();
            newDict.Add(1, "Juan");
            newDict.Add(2, "Juana");
            newDict.Add(3, "Juana Man");
            newDict.Add(4, "Juana Man to ");
            newDict.Add(5, "Juana man to hit you");

            string value = newDict[4];

            Console.WriteLine(value);

        }
    }
}
