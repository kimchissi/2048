using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Matthew Arndt & Michael Kelley - 2048
 * This is the class that handles all actions with the form - it is essentially the main driver of the game.
 * 2048 is a game in which the objective is to get a tile that reads "2048". You lose when there is no more moves you can make on the board.
 * You can move the game board with the "WASD" keys instead of tediously pressing the arrow keys on the Windows form.
*/

namespace TwentyFortyEight
{
    public partial class frmTwentyFortyEight : Form
    {
        public frmTwentyFortyEight()
        {
            InitializeComponent();
        }
        //test2

        private void frmTwentyFortyEight_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "A":
                    btnLeft.PerformClick();
                    break;
                case "W":
                    btnUp.PerformClick();
                    break;
                case "D":
                    btnRight.PerformClick();
                    break;
                case "S":
                    btnDown.PerformClick();
                    break;
                default:
                    break;
            }

        }

        private void frmTwentyFortyEight_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //makes the form look for key presses
        }

        private void btnLeft_Click(object sender, EventArgs e)//triggers when user presses "a" or clicks the left arrow
        {
            
        }
        private void btnUp_Click(object sender, EventArgs e)//triggers when the user presses "w" or presses the up arrow
        {
            
        }
        private void btnRight_Click(object sender, EventArgs e)//triggers when the user presses "d" or presses the right arrow
        {
            
        }
        private void btnDown_Click(object sender, EventArgs e)//triggers when the user presses "s" or presses the down arrow
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            if (name == "" || name == "Name" || name == " " || name == null) //if the user entered a name
            {
                MessageBox.Show("You must enter in a name the play the game");
            }
            else //user entered a valied name
            {
                MessageBox.Show("Welcome to 2048! Press rules to read the rules, \n" +
                    "To start a game, press the new button \n" +
                    " move with the WASD keys or simply press the buttons at the bottom");
                //turning the name functionality off, and everything else on
                txtName.Enabled = false;
                btnOk.Enabled = false;
                txtScore.Enabled = true;
                btnNew.Enabled = true;
                btnRules.Enabled = true;
                btnRight.Enabled = true;
                btnDown.Enabled = true;
                btnLeft.Enabled = true;
                btnUp.Enabled = true;
            }
        
        }

        private void btnClose_Click(object sender, EventArgs e) //closes the form when the user clicks "close"
        {
            this.Close();
        }

        //When the user clicks on the name textbox, the name placeholder field dissapears
        private void txtName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
            }
            txtName.ForeColor = Color.Black;
        }

    }
}
