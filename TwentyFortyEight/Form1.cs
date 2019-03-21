using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            if (e.KeyCode.ToString() == "A")
            {
                btnLeft.PerformClick();
            }
            if (e.KeyCode.ToString() == "W")
            {
                btnUp.PerformClick();
            }
            if (e.KeyCode.ToString() == "D")
            {
                btnRight.PerformClick();
            }
            if (e.KeyCode.ToString() == "S")
            {
                btnDown.PerformClick();
            }
            
        }

        private void frmTwentyFortyEight_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            if (txtName.Text != "Name")
            {

            }
            txtScore.Enabled = true;


        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LEFT WORKED");
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UP WORKED");
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RIGHT WORKED");
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DOWN WORKED");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("really quick!");
            txtName.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
            }
        }
    }
}
