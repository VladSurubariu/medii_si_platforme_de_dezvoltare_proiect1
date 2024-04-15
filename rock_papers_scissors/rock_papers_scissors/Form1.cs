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
        /* Initialise objects for each option */
        Rock rock = new Rock();
        Paper paper = new Paper();
        Option option = new Option();
        Scissors scissors = new Scissors();

        /* Initialise object for the computer actions */
        /* When the object initialised a choice was generated */
        ComputerChoice computer = new ComputerChoice();

        public Form1()
        {
            InitializeComponent();

        }
        private void change_button_Click(object sender, EventArgs e)
        {
            /* Change user-picture everytime the button is clicked */
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

        private void choose_button_Click(object sender, EventArgs e)
        {
            /* If the picture is not the default one */
            if ((string)userPictureBox.Tag != option.GetName())
            {
                /* Add the picture to the computer's image */ 
                computerPictureBox.Image = computer.GetPicture();

                /* Initialise the mediator object and pass the choices as arguments */
                Mediator mediator = new Mediator(userPictureBox.Tag.ToString(), computer.GetName());

                /* Compare the arguments passed inside constructor and return the winner */
                int winner = mediator.DecideWinner();

                if (winner == -1)
                {
                    MessageBox.Show("Congrats! You win!");
                }
                else if (winner == 1)
                {
                    MessageBox.Show("Ouf! You lost!");
                }
                else
                {
                    MessageBox.Show("Tie!");
                }

                /* Since the computer's choice has been used, generate a new one already */
                computer.GenerateNewNumber();
            }
        }
    }
}
