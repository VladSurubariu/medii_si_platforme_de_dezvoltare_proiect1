using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors
{
    public class Rock
    {

        public string GetName()
        {
            return "rock";
        }

        public System.Drawing.Bitmap GetPicture()
        {
            return Properties.Resources.fist;
        }
        
    }
}
