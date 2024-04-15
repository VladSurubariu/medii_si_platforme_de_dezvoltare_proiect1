using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors
{
    public class Mediator
    {
        string user_choice;
        string computer_choice;

        public Mediator(string _user_choice, string _computer_choice)
        {
            user_choice = _user_choice;
            computer_choice = _computer_choice;
        }

        public int DecideWinner()
        {
            if (user_choice == computer_choice) 
            {
                return 0;
            }
            else
            {
                if (user_choice == "rock" && computer_choice == "scissors")
                {
                    return -1;
                }
                if (user_choice == "scissors" && computer_choice == "paper")
                {
                    return -1;
                }
                if (user_choice == "paper" && computer_choice == "rock")
                {
                    return -1;
                }

                return 1;
            }
        }
    }
}
