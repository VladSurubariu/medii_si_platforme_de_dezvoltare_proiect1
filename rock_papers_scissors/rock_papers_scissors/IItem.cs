using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors
{
    /* Item basic interface. Acts as a factory for creating the objects used inside the project */
    /* Rock, Scissors, Paper and Default have been created with this interface. */
    /* Each of them has the same methods, but overriden diferently */
    public interface IItem
    {
        string GetName();
        System.Drawing.Bitmap GetPicture();

    }
}
