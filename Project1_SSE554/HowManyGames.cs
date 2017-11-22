using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_SSE554
{
    public partial class HowManyGames : Form
    {
        GameType chosen = new GameType();
        List<Thread> threads = new List<Thread>();
        int number;
        public HowManyGames()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object numberGames = comboBox1.SelectedItem;
            if (comboBox1.SelectedItem == null)
                MessageBox.Show("Please select a value");
            else
            {
                number = Int32.Parse((string)numberGames);
                if (number == 1)
                {
                    ChooseGameType games = new ChooseGameType();
                    games.Show();
                    this.Hide();
                }
                else
                {
                    checkedListBox1.Visible = true;
                    button3.Visible = false;
                    button1.Visible = true;
                    
                }
            }
        }
        private void callChooseGameType(string game)
        {
            game = game.Replace(" ", "");
            int gameType = chosen.setGameType(game);

            if (gameType == 10)
                MessageBox.Show("Please Select a Game");
            else if (gameType == 0 || gameType == 1)
            {
                GameResults selection = new GameResults(gameType);
                selection.Show();
                //this.Hide();
            }
            else if (gameType == 3)
            {
                GuessTheTvShow selection = new GuessTheTvShow();
                selection.Show();
                //this.Hide();
            }
            else if (gameType == 4)
            {
                Yahtzee selection = new Yahtzee();
                selection.Show();
                //this.Hide();
            }
            else
            {
                GuessTheNumber selection = new GuessTheNumber(chosen.numberRangeChosen("1-10"));
                selection.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] row = new string[4];
            Thread thread1;
            int select = Convert.ToInt32(comboBox1.SelectedItem);
            foreach (object item in checkedListBox1.CheckedItems)
            {
                row[count] = (string)item;
                count++;
            }
            if (count != number)
            {
                MessageBox.Show("Please select the number of games equal to the number chosen");
            }
            else
            {
                //Thread.Sleep(100000);

                for (int i = 0; i < number; i++)
                {
                    thread1 = new Thread(() => callChooseGameType(row[i]));
                    thread1.Start();
                    //threads.Add(thread1);
                    // threads.ElementAt(i);
                }
                this.Hide();
            }
        }
    }
}
