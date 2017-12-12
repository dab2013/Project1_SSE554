namespace Project1_SSE554
{
    partial class IceCreamAndBurgerShop
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
            this.Customer1IceCreamFlavor = new System.Windows.Forms.TextBox();
            this.Customer1IceCreamToppings = new System.Windows.Forms.TextBox();
            this.Toppings = new System.Windows.Forms.CheckedListBox();
            this.VanillaChoice = new System.Windows.Forms.RadioButton();
            this.StrawberryChoice = new System.Windows.Forms.RadioButton();
            this.ChocolateChoice = new System.Windows.Forms.RadioButton();
            this.CottonCandyChoice = new System.Windows.Forms.RadioButton();
            this.CookiesChoice = new System.Windows.Forms.RadioButton();
            this.Customer2IceCreamFlavor = new System.Windows.Forms.TextBox();
            this.Customer3IceCreamFlavor = new System.Windows.Forms.TextBox();
            this.Customer4IceCreamFlavor = new System.Windows.Forms.TextBox();
            this.Customer5IceCreamFlavor = new System.Windows.Forms.TextBox();
            this.Customer5IceCreamToppings = new System.Windows.Forms.TextBox();
            this.Customer4IceCreamToppings = new System.Windows.Forms.TextBox();
            this.Customer3IceCreamToppings = new System.Windows.Forms.TextBox();
            this.Customer2IceCreamToppings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer1IceCreamFlavor
            // 
            this.Customer1IceCreamFlavor.Enabled = false;
            this.Customer1IceCreamFlavor.Location = new System.Drawing.Point(383, 84);
            this.Customer1IceCreamFlavor.Name = "Customer1IceCreamFlavor";
            this.Customer1IceCreamFlavor.Size = new System.Drawing.Size(118, 20);
            this.Customer1IceCreamFlavor.TabIndex = 0;
            // 
            // Customer1IceCreamToppings
            // 
            this.Customer1IceCreamToppings.Enabled = false;
            this.Customer1IceCreamToppings.Location = new System.Drawing.Point(517, 84);
            this.Customer1IceCreamToppings.Name = "Customer1IceCreamToppings";
            this.Customer1IceCreamToppings.Size = new System.Drawing.Size(324, 20);
            this.Customer1IceCreamToppings.TabIndex = 1;
            // 
            // Toppings
            // 
            this.Toppings.CheckOnClick = true;
            this.Toppings.FormattingEnabled = true;
            this.Toppings.Items.AddRange(new object[] {
            "Caramel",
            "Cherries",
            "Chocolate Syrup",
            "Gummi Bears",
            "Oreos",
            "Sprinkles",
            "Strawberries",
            "Whip Cream"});
            this.Toppings.Location = new System.Drawing.Point(125, 87);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(120, 124);
            this.Toppings.TabIndex = 2;
            // 
            // VanillaChoice
            // 
            this.VanillaChoice.AutoSize = true;
            this.VanillaChoice.Checked = true;
            this.VanillaChoice.Location = new System.Drawing.Point(12, 87);
            this.VanillaChoice.Name = "VanillaChoice";
            this.VanillaChoice.Size = new System.Drawing.Size(56, 17);
            this.VanillaChoice.TabIndex = 3;
            this.VanillaChoice.TabStop = true;
            this.VanillaChoice.Text = "Vanilla";
            this.VanillaChoice.UseVisualStyleBackColor = true;
            this.VanillaChoice.CheckedChanged += new System.EventHandler(this.IceCreamFlavors_CheckedChanged);
            // 
            // StrawberryChoice
            // 
            this.StrawberryChoice.AutoSize = true;
            this.StrawberryChoice.Location = new System.Drawing.Point(12, 133);
            this.StrawberryChoice.Name = "StrawberryChoice";
            this.StrawberryChoice.Size = new System.Drawing.Size(75, 17);
            this.StrawberryChoice.TabIndex = 4;
            this.StrawberryChoice.Text = "Strawberry";
            this.StrawberryChoice.UseVisualStyleBackColor = true;
            this.StrawberryChoice.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ChocolateChoice
            // 
            this.ChocolateChoice.AutoSize = true;
            this.ChocolateChoice.Location = new System.Drawing.Point(12, 110);
            this.ChocolateChoice.Name = "ChocolateChoice";
            this.ChocolateChoice.Size = new System.Drawing.Size(73, 17);
            this.ChocolateChoice.TabIndex = 5;
            this.ChocolateChoice.Text = "Chocolate";
            this.ChocolateChoice.UseVisualStyleBackColor = true;
            this.ChocolateChoice.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CottonCandyChoice
            // 
            this.CottonCandyChoice.AutoSize = true;
            this.CottonCandyChoice.Location = new System.Drawing.Point(12, 179);
            this.CottonCandyChoice.Name = "CottonCandyChoice";
            this.CottonCandyChoice.Size = new System.Drawing.Size(89, 17);
            this.CottonCandyChoice.TabIndex = 6;
            this.CottonCandyChoice.Text = "Cotton Candy";
            this.CottonCandyChoice.UseVisualStyleBackColor = true;
            this.CottonCandyChoice.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // CookiesChoice
            // 
            this.CookiesChoice.AutoSize = true;
            this.CookiesChoice.Location = new System.Drawing.Point(12, 156);
            this.CookiesChoice.Name = "CookiesChoice";
            this.CookiesChoice.Size = new System.Drawing.Size(107, 17);
            this.CookiesChoice.TabIndex = 7;
            this.CookiesChoice.Text = "Cookies n\' Cream";
            this.CookiesChoice.UseVisualStyleBackColor = true;
            this.CookiesChoice.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Customer2IceCreamFlavor
            // 
            this.Customer2IceCreamFlavor.Enabled = false;
            this.Customer2IceCreamFlavor.Location = new System.Drawing.Point(383, 110);
            this.Customer2IceCreamFlavor.Name = "Customer2IceCreamFlavor";
            this.Customer2IceCreamFlavor.Size = new System.Drawing.Size(118, 20);
            this.Customer2IceCreamFlavor.TabIndex = 8;
            // 
            // Customer3IceCreamFlavor
            // 
            this.Customer3IceCreamFlavor.Enabled = false;
            this.Customer3IceCreamFlavor.Location = new System.Drawing.Point(383, 136);
            this.Customer3IceCreamFlavor.Name = "Customer3IceCreamFlavor";
            this.Customer3IceCreamFlavor.Size = new System.Drawing.Size(118, 20);
            this.Customer3IceCreamFlavor.TabIndex = 9;
            // 
            // Customer4IceCreamFlavor
            // 
            this.Customer4IceCreamFlavor.Enabled = false;
            this.Customer4IceCreamFlavor.Location = new System.Drawing.Point(383, 162);
            this.Customer4IceCreamFlavor.Name = "Customer4IceCreamFlavor";
            this.Customer4IceCreamFlavor.Size = new System.Drawing.Size(118, 20);
            this.Customer4IceCreamFlavor.TabIndex = 10;
            // 
            // Customer5IceCreamFlavor
            // 
            this.Customer5IceCreamFlavor.Enabled = false;
            this.Customer5IceCreamFlavor.Location = new System.Drawing.Point(383, 188);
            this.Customer5IceCreamFlavor.Name = "Customer5IceCreamFlavor";
            this.Customer5IceCreamFlavor.Size = new System.Drawing.Size(118, 20);
            this.Customer5IceCreamFlavor.TabIndex = 11;
            // 
            // Customer5IceCreamToppings
            // 
            this.Customer5IceCreamToppings.Enabled = false;
            this.Customer5IceCreamToppings.Location = new System.Drawing.Point(517, 191);
            this.Customer5IceCreamToppings.Name = "Customer5IceCreamToppings";
            this.Customer5IceCreamToppings.Size = new System.Drawing.Size(324, 20);
            this.Customer5IceCreamToppings.TabIndex = 13;
            // 
            // Customer4IceCreamToppings
            // 
            this.Customer4IceCreamToppings.Enabled = false;
            this.Customer4IceCreamToppings.Location = new System.Drawing.Point(517, 162);
            this.Customer4IceCreamToppings.Name = "Customer4IceCreamToppings";
            this.Customer4IceCreamToppings.Size = new System.Drawing.Size(324, 20);
            this.Customer4IceCreamToppings.TabIndex = 14;
            // 
            // Customer3IceCreamToppings
            // 
            this.Customer3IceCreamToppings.Enabled = false;
            this.Customer3IceCreamToppings.Location = new System.Drawing.Point(517, 136);
            this.Customer3IceCreamToppings.Name = "Customer3IceCreamToppings";
            this.Customer3IceCreamToppings.Size = new System.Drawing.Size(324, 20);
            this.Customer3IceCreamToppings.TabIndex = 15;
            // 
            // Customer2IceCreamToppings
            // 
            this.Customer2IceCreamToppings.Enabled = false;
            this.Customer2IceCreamToppings.Location = new System.Drawing.Point(517, 110);
            this.Customer2IceCreamToppings.Name = "Customer2IceCreamToppings";
            this.Customer2IceCreamToppings.Size = new System.Drawing.Size(324, 20);
            this.Customer2IceCreamToppings.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customers\' Orders";
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.Location = new System.Drawing.Point(261, 136);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(106, 23);
            this.SubmitOrder.TabIndex = 18;
            this.SubmitOrder.Text = "Submit Order ->";
            this.SubmitOrder.UseVisualStyleBackColor = true;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 80;
            this.button5.Text = "<- back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // IceCreamShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 247);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Customer2IceCreamToppings);
            this.Controls.Add(this.Customer3IceCreamToppings);
            this.Controls.Add(this.Customer4IceCreamToppings);
            this.Controls.Add(this.Customer5IceCreamToppings);
            this.Controls.Add(this.Customer5IceCreamFlavor);
            this.Controls.Add(this.Customer4IceCreamFlavor);
            this.Controls.Add(this.Customer3IceCreamFlavor);
            this.Controls.Add(this.Customer2IceCreamFlavor);
            this.Controls.Add(this.CookiesChoice);
            this.Controls.Add(this.CottonCandyChoice);
            this.Controls.Add(this.ChocolateChoice);
            this.Controls.Add(this.StrawberryChoice);
            this.Controls.Add(this.VanillaChoice);
            this.Controls.Add(this.Toppings);
            this.Controls.Add(this.Customer1IceCreamToppings);
            this.Controls.Add(this.Customer1IceCreamFlavor);
            this.Name = "IceCreamShop";
            this.Text = "IceCreamShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Customer1IceCreamFlavor;
        private System.Windows.Forms.TextBox Customer1IceCreamToppings;
        private System.Windows.Forms.CheckedListBox Toppings;
        private System.Windows.Forms.RadioButton VanillaChoice;
        private System.Windows.Forms.RadioButton StrawberryChoice;
        private System.Windows.Forms.RadioButton ChocolateChoice;
        private System.Windows.Forms.RadioButton CottonCandyChoice;
        private System.Windows.Forms.RadioButton CookiesChoice;
        private System.Windows.Forms.TextBox Customer2IceCreamFlavor;
        private System.Windows.Forms.TextBox Customer3IceCreamFlavor;
        private System.Windows.Forms.TextBox Customer4IceCreamFlavor;
        private System.Windows.Forms.TextBox Customer5IceCreamFlavor;
        private System.Windows.Forms.TextBox Customer5IceCreamToppings;
        private System.Windows.Forms.TextBox Customer4IceCreamToppings;
        private System.Windows.Forms.TextBox Customer3IceCreamToppings;
        private System.Windows.Forms.TextBox Customer2IceCreamToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitOrder;
        private System.Windows.Forms.Button button5;
    }
}