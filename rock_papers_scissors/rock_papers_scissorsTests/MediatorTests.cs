using Microsoft.VisualStudio.TestTools.UnitTesting;
using rock_papers_scissors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors.Tests
{
    [TestClass()]
    public class MediatorTests
    {
        /// Description   Test checks if the computer wins
        /// Precondition  Mediator object initialised
        ///               Mediator.user_choice = "rock"
        ///               Mediator.computer_choice = "paper"
        /// Result        The function return 1 if the computer wins the game.
        [TestMethod()]
        public void DecideWinnerTest_ComputerWin()
        {
            Mediator mediator = new Mediator("rock", "paper");

            int actual_result = mediator.DecideWinner();
            int expected_result = 1;

            Assert.AreEqual(expected_result, actual_result);
        }

        /// Description   Test checks if the user wins
        /// Precondition  Mediator object initialised
        ///               Mediator.user_choice = "rock"
        ///               Mediator.computer_choice = "scissors"
        /// Result        The function return -1 if the user wins the game.
        [TestMethod()]
        public void DecideWinnerTest_UserWin()
        {
            Mediator mediator = new Mediator("rock", "scissors");

            int actual_result = mediator.DecideWinner();
            int expected_result = -1;

            Assert.AreEqual(expected_result, actual_result);
        }

        /// Description   Test checks if the user and the computer chose the same option
        /// Precondition  Mediator object initialised
        ///               Mediator.user_choice = "rock"
        ///               Mediator.computer_choice = "rock"
        /// Result        The function return 0 if there is equality.
        [TestMethod()]
        public void DecideWinnerTest_Equal()
        {
            Mediator mediator = new Mediator("rock", "rock");

            int actual_result = mediator.DecideWinner();
            int expected_result = 0;

            Assert.AreEqual(expected_result, actual_result);
        }
    }
}