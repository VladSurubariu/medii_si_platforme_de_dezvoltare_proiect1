using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papers_scissors
{
    public interface IItem
    {
        string GetName();
        System.Drawing.Bitmap GetPicture();

    }
}
