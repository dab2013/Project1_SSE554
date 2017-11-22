using System;
using System.Windows.Forms;

namespace Project1_SSE554
{
    public partial class GameResults : Form
    {
        string choice, finalChoice;
        int userWinCount = 0;
        int computerWinCount = 0;
        int gameType;

        public GameResults(int gameChoice)
        {
            InitializeComponent();
            gameType = gameChoice;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choice = "rock";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choice = "paper";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            choice = "scissors";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            choice = "lizard";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            choice = "spock";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (choice != null)
            {
                finalChoice = choice;
                showPictureBox(pictureBox2, finalChoice);
                Random rnd1 = new Random();
                int computerChoice = rnd1.Next(1, 6);
                string computerChoiceString = computerSelection(computerChoice);
                showPictureBox(pictureBox1, computerChoiceString);
                winner(choice, computerChoiceString);

                if (gameType == 1 && (userWinCount == 2 || computerWinCount == 2))
                {
                    if(userWinCount == 2)
                        MessageBox.Show("You Win - Congratulations");
                    else
                        MessageBox.Show("Computer Wins - Better luck next time");
                    
                    button2.Enabled = false;
                    button1.Visible = true;
                }
            }
            else
                MessageBox.Show("No Selection Was Made!");
        }

        public void winner(string user, string computer)
        {
            var results = GameResultsClass.getResultsFactory(user, computer);
            if (results != null || results.getFinalsSaying() != "")
                textBox1.Text = results.getFinalsSaying();

            string win = "You Win";
            string lose = "You Lose";

            if ((textBox1.Text).Contains(win))
                userWinCount++;
            else if ((textBox1.Text).Contains(lose))
                computerWinCount++;

            textBox2.Text = (userWinCount).ToString() +" - " + (computerWinCount).ToString();
        }

        public string computerSelection(int random)
        {
            string selection ="";

            if (random == 1)
                selection = "rock";
            else if (random == 2)
                selection = "paper";
            else if (random == 3)
                selection = "scissors";
            else if (random == 4)
                selection = "lizard";
            else if (random == 5)
                selection = "spock";

            return selection;
        }

        public void showPictureBox(PictureBox thePicture, string choice)
        {
            thePicture.ImageLocation = @"C:\Users\Daniel\Documents\Visual Studio 2015\Projects\Project1_SSE554\Project1_SSE554\Images\" + choice + ".jpg";
            thePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            thePicture.Refresh();
            thePicture.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChooseGameType again = new ChooseGameType();
            again.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameResults again = new GameResults(gameType);
            again.Show();
            this.Hide();
        }
    }
}
