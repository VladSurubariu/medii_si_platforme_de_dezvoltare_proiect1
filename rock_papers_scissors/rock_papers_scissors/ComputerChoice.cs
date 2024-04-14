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

        public ComputerChoice()
        {
            GenerateNewNumber();
        }

        public void GenerateNewNumber()
        {
            Random random = new Random();

            ix = random.Next(choices.Length);
        }

        public string GetName()
        {
            return choices[ix];
        }

        public Bitmap GetPicture()
        {
            return bitmaps[ix];
        }
    }
}
