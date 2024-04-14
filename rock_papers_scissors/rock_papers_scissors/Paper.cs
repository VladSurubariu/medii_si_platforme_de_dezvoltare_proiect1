using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors
{
    internal class Paper
    {
        public string GetName()
        {
            return "paper";
        }

        public System.Drawing.Bitmap GetPicture()
        {
            return Properties.Resources.hand_paper;
        }
    }
}
