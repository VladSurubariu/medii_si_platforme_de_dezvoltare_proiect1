using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors
{
    internal class ComputerChoice : IItem
    {
        int ix;
        string[] choices = { "rock", "paper", "scissors" };
        Bitmap[] bitmaps = { Properties.Resources.fist, Properties.Resources.hand_paper, Properties.Resources.scissors };

        /* Basic constructor */
        public ComputerChoice()
        {
            GenerateNewNumber();
        }

        /* Function that generates a random number */
        public void GenerateNewNumber()
        {
            Random random = new Random();

            ix = random.Next(choices.Length);
        }

        /* Get choice */
        public string GetName()
        {
            return choices[ix];
        }

        /* Get Picture */
        public Bitmap GetPicture()
        {
            return bitmaps[ix];
        }
    }
}
