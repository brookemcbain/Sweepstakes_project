using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Contestant
    {
        string firstName;
        string lastName;
        string emailAddress;
        
        public Contestant()
        {

            firstName = UserInterface.GetUserInputString(" What is your first name? ");
            lastName = UserInterface.GetUserInputString("What is your last name?");
            emailAddress = UserInterface.GetUserInputString("What is your email address?");
    
        }
      
    }
}
