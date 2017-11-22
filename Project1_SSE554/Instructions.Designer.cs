namespace Project1_SSE554
{
    partial class Instructions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lock = new System.Windows.Forms.PictureBox();
            this.Unlock = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.RollDice = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lock
            // 
            this.Lock.Location = new System.Drawing.Point(12, 76);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(29, 30);
            this.Lock.TabIndex = 70;
            this.Lock.TabStop = false;
            // 
            // Unlock
            // 
            this.Unlock.Location = new System.Drawing.Point(80, 76);
            this.Unlock.Name = "Unlock";
            this.Unlock.Size = new System.Drawing.Size(31, 30);
            this.Unlock.TabIndex = 71;
            this.Unlock.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(463, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 72;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(144, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(331, 75);
            this.richTextBox1.TabIndex = 73;
            this.richTextBox1.Text = "This is equivalent to writing down a number, but after submit and roll is pressed" +
    " the number cannot be unlocked. \n\nlock - write down number\nunlock - erase number" +
    "";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(12, 170);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(99, 23);
            this.Submit.TabIndex = 74;
            this.Submit.Text = "Submit and Roll";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(144, 157);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(331, 48);
            this.richTextBox2.TabIndex = 75;
            this.richTextBox2.Text = "This button only works when one of the the user has pressed the lock button.This " +
    "locks the answer so it cannot be changed and begins the next round.";
            // 
            // RollDice
            // 
            this.RollDice.Location = new System.Drawing.Point(26, 256);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(75, 23);
            this.RollDice.TabIndex = 76;
            this.RollDice.Text = "Roll";
            this.RollDice.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Location = new System.Drawing.Point(144, 243);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(331, 36);
            this.richTextBox3.TabIndex = 77;
            this.richTextBox3.Text = "This button allows the user to roll three times before locking and forcing the us" +
    "er to choose a number.";
            // 
            // Dice1
            // 
            this.Dice1.Location = new System.Drawing.Point(44, 309);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(43, 40);
            this.Dice1.TabIndex = 78;
            this.Dice1.TabStop = false;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Location = new System.Drawing.Point(144, 318);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(331, 21);
            this.richTextBox4.TabIndex = 79;
            this.richTextBox4.Text = "Click on one or multiple dice to keep or roll again.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.30769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.69231F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox12, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox11, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox10, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox9, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox13, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox15, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox17, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(760, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.19277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.80723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 283);
            this.tableLayoutPanel1.TabIndex = 80;
            // 
            // richTextBox12
            // 
            this.richTextBox12.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox12.ForeColor = System.Drawing.Color.Black;
            this.richTextBox12.Location = new System.Drawing.Point(86, 259);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.Size = new System.Drawing.Size(170, 20);
            this.richTextBox12.TabIndex = 89;
            this.richTextBox12.Text = "100*(# of extra yahtzees rolled)";
            // 
            // richTextBox11
            // 
            this.richTextBox11.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox11.ForeColor = System.Drawing.Color.Black;
            this.richTextBox11.Location = new System.Drawing.Point(86, 233);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(170, 20);
            this.richTextBox11.TabIndex = 88;
            this.richTextBox11.Text = "Sum of all the dices";
            // 
            // richTextBox10
            // 
            this.richTextBox10.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox10.ForeColor = System.Drawing.Color.Black;
            this.richTextBox10.Location = new System.Drawing.Point(86, 194);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(170, 32);
            this.richTextBox10.TabIndex = 87;
            this.richTextBox10.Text = "50 points if the user has five of the same dice";
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.ForeColor = System.Drawing.Color.Black;
            this.richTextBox9.Location = new System.Drawing.Point(86, 157);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(170, 31);
            this.richTextBox9.TabIndex = 86;
            this.richTextBox9.Text = "40 points if the user has five dice is sequential order";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.ForeColor = System.Drawing.Color.Black;
            this.richTextBox8.Location = new System.Drawing.Point(86, 120);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(170, 31);
            this.richTextBox8.TabIndex = 85;
            this.richTextBox8.Text = "30 points if the user has four or more dice is sequential order";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.ForeColor = System.Drawing.Color.Black;
            this.richTextBox7.Location = new System.Drawing.Point(86, 81);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(170, 33);
            this.richTextBox7.TabIndex = 84;
            this.richTextBox7.Text = "25 points if the user has two of a kind and three of a kind";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.ForeColor = System.Drawing.Color.Black;
            this.richTextBox6.Location = new System.Drawing.Point(86, 41);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(170, 33);
            this.richTextBox6.TabIndex = 83;
            this.richTextBox6.Text = "total of dice if the usr has four or more of the same dice";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.ForeColor = System.Drawing.Color.Black;
            this.richTextBox5.Location = new System.Drawing.Point(86, 3);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(170, 32);
            this.richTextBox5.TabIndex = 82;
            this.richTextBox5.Text = "total of dice if the usr has three or more of the same dice";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(3, 157);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(77, 13);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Lg. Straight";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(3, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(77, 13);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Full House";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(3, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 13);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Four of a Kind";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Three of a Kind";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(3, 120);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(77, 13);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Sm. Straight";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.ForeColor = System.Drawing.Color.Black;
            this.textBox13.Location = new System.Drawing.Point(3, 194);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(77, 13);
            this.textBox13.TabIndex = 12;
            this.textBox13.Text = "Yahtzee";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.ForeColor = System.Drawing.Color.Black;
            this.textBox15.Location = new System.Drawing.Point(3, 233);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(77, 13);
            this.textBox15.TabIndex = 14;
            this.textBox15.Text = "Chance ";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.ForeColor = System.Drawing.Color.Black;
            this.textBox17.Location = new System.Drawing.Point(3, 259);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(77, 13);
            this.textBox17.TabIndex = 16;
            this.textBox17.Text = "Bonus Yahtzees";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.5F));
            this.tableLayoutPanel2.Controls.Add(this.richTextBox13, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBox29, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox30, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox31, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox32, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox33, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox34, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox35, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox36, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox37, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox38, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox39, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox40, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox28, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(525, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 154);
            this.tableLayoutPanel2.TabIndex = 81;
            // 
            // textBox29
            // 
            this.textBox29.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox29.ForeColor = System.Drawing.Color.Black;
            this.textBox29.Location = new System.Drawing.Point(42, 94);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(94, 13);
            this.textBox29.TabIndex = 11;
            this.textBox29.Text = "6*(# of Sixes)";
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox30.ForeColor = System.Drawing.Color.Black;
            this.textBox30.Location = new System.Drawing.Point(3, 94);
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(33, 13);
            this.textBox30.TabIndex = 10;
            this.textBox30.Text = "Sixes";
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox31.ForeColor = System.Drawing.Color.Black;
            this.textBox31.Location = new System.Drawing.Point(42, 76);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(94, 13);
            this.textBox31.TabIndex = 9;
            this.textBox31.Text = "5*(# of Fives)";
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox32.ForeColor = System.Drawing.Color.Black;
            this.textBox32.Location = new System.Drawing.Point(3, 76);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(33, 13);
            this.textBox32.TabIndex = 8;
            this.textBox32.Text = "Fives";
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox33.ForeColor = System.Drawing.Color.Black;
            this.textBox33.Location = new System.Drawing.Point(42, 58);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(94, 13);
            this.textBox33.TabIndex = 7;
            this.textBox33.Text = "4*(# of Fours)";
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox34.ForeColor = System.Drawing.Color.Black;
            this.textBox34.Location = new System.Drawing.Point(3, 58);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(33, 13);
            this.textBox34.TabIndex = 6;
            this.textBox34.Text = "Fours";
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox35.ForeColor = System.Drawing.Color.Black;
            this.textBox35.Location = new System.Drawing.Point(42, 40);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(94, 13);
            this.textBox35.TabIndex = 5;
            this.textBox35.Text = "3*(# of Threes)";
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox36.ForeColor = System.Drawing.Color.Black;
            this.textBox36.Location = new System.Drawing.Point(3, 40);
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(33, 13);
            this.textBox36.TabIndex = 4;
            this.textBox36.Text = "Threes";
            // 
            // textBox37
            // 
            this.textBox37.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox37.ForeColor = System.Drawing.Color.Black;
            this.textBox37.Location = new System.Drawing.Point(42, 21);
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(94, 13);
            this.textBox37.TabIndex = 3;
            this.textBox37.Text = "2*(# of Twos)";
            // 
            // textBox38
            // 
            this.textBox38.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox38.ForeColor = System.Drawing.Color.Black;
            this.textBox38.Location = new System.Drawing.Point(3, 21);
            this.textBox38.Name = "textBox38";
            this.textBox38.ReadOnly = true;
            this.textBox38.Size = new System.Drawing.Size(33, 13);
            this.textBox38.TabIndex = 2;
            this.textBox38.Text = "Twos";
            // 
            // textBox39
            // 
            this.textBox39.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox39.ForeColor = System.Drawing.Color.Black;
            this.textBox39.Location = new System.Drawing.Point(42, 3);
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            this.textBox39.Size = new System.Drawing.Size(94, 13);
            this.textBox39.TabIndex = 1;
            this.textBox39.Text = "1*(# of Ones)";
            // 
            // textBox40
            // 
            this.textBox40.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox40.ForeColor = System.Drawing.Color.Black;
            this.textBox40.Location = new System.Drawing.Point(3, 3);
            this.textBox40.Name = "textBox40";
            this.textBox40.ReadOnly = true;
            this.textBox40.Size = new System.Drawing.Size(33, 13);
            this.textBox40.TabIndex = 0;
            this.textBox40.Text = "Aces";
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox28.ForeColor = System.Drawing.Color.Black;
            this.textBox28.Location = new System.Drawing.Point(3, 112);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(33, 13);
            this.textBox28.TabIndex = 12;
            this.textBox28.Text = "Bonus";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(696, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 24);
            this.textBox2.TabIndex = 82;
            this.textBox2.Text = "Scoring";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox13
            // 
            this.richTextBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox13.ForeColor = System.Drawing.Color.Black;
            this.richTextBox13.Location = new System.Drawing.Point(42, 112);
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.Size = new System.Drawing.Size(155, 39);
            this.richTextBox13.TabIndex = 83;
            this.richTextBox13.Text = "35 bonus points if the sum of the above categories is equal to or greater than 63" +
    " ";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 395);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.RollDice);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Unlock);
            this.Controls.Add(this.Lock);
            this.Name = "Instructions";
            this.Text = "Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.Lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Lock;
        private System.Windows.Forms.PictureBox Unlock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.RichTextBox richTextBox12;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox13;
    }
}