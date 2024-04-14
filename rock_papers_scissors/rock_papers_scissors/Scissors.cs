using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors
{
    internal class Scissors
    {
        public string GetName()
        {
            return "scissors";
        }

        public System.Drawing.Bitmap GetPicture()
        {
            return Properties.Resources.scissors;
        }
    }
}
