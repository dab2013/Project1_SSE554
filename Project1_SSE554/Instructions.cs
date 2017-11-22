using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_SSE554
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
            button1.Enabled = false;
            button1.Enabled = true;
            RollDice.Enabled = true;
            Submit.Enabled = true;
            textBox2.Enabled = true;
            textBox2.ReadOnly = true;
            showPictureBox(Lock, @"C:\Users\Daniel\Documents\Visual Studio 2015\Projects\Project1_SSE554\Project1_SSE554\Images\lock.png");
            showPictureBox(Unlock, @"C:\Users\Daniel\Documents\Visual Studio 2015\Projects\Project1_SSE554\Project1_SSE554\Images\unlock.png");
            showPictureBox(Dice1, @"C:\Users\Daniel\Documents\Visual Studio 2015\Projects\Project1_SSE554\Project1_SSE554\Images\One.jpg");
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void showPictureBox(PictureBox thePicture, string pic)
        {
            thePicture.ImageLocation = pic;
            thePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            thePicture.Refresh();
            thePicture.Visible = true;
        }
    }
}
