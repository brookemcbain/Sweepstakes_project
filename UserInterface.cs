using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    static class UserInterface
    {
        
        public static string GetUserInputString(string message)
        {
            Console.WriteLine(message);
            string answer = Console.ReadLine();
            return answer; 
        }
        public static void DisplayContestantInfo(Contestant contestantInfo, Contestant registrationNumber)
        {
            Console.WriteLine("The winner is: ");
            Console.WriteLine(contestantInfo); 
            Console.WriteLine(registrationNumber); 
        }
    }
}
