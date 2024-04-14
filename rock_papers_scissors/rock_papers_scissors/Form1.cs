using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_papers_scissors
{
    public partial class Form1 : Form
    {
        Rock rock = new Rock();
        Paper paper = new Paper();
        Scissors scissors = new Scissors();
        Option option= new Option();

        public Form1()
        {
            InitializeComponent();

        }
        private void change_button_Click(object sender, EventArgs e)
        {
            if ((string)userPictureBox.Tag == option.GetName())
            {
                userPictureBox.Image = rock.GetPicture();
                userPictureBox.Tag = rock.GetName();
            }
            else if ((string)userPictureBox.Tag == rock.GetName())
            {
                userPictureBox.Image = paper.GetPicture();
                userPictureBox.Tag = paper.GetName();
            }
            else if ((string)userPictureBox.Tag == paper.GetName())
            {
                userPictureBox.Image = scissors.GetPicture();
                userPictureBox.Tag = scissors.GetName();
            }
            else if ((string)userPictureBox.Tag == scissors.GetName())
            {
                userPictureBox.Image = rock.GetPicture();
                userPictureBox.Tag = rock.GetName();
            }
        }
    }
}
