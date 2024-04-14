using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors
{
    internal class Option
    {
        public Option() { }
        public string GetName()
        {
            return "option";
        }

        public System.Drawing.Bitmap GetPicture()
        {
            return Properties.Resources.question;
        }
    }
}
