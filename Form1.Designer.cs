namespace HangmanGameDesktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxGalge = new System.Windows.Forms.PictureBox();
            this.textBoxShowScore = new System.Windows.Forms.TextBox();
            this.textBoxShowLife = new System.Windows.Forms.TextBox();
            this.textBoxShowWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxShowHiddenWord = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.textBoxShowUsedLetters = new System.Windows.Forms.TextBox();
            this.button28 = new System.Windows.Forms.Button();
            this.textBoxRoundShow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGalge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGalge
            // 
            this.pictureBoxGalge.Image = global::HangmanGameDesktop.Properties.Resources.forkert0;
            this.pictureBoxGalge.Location = new System.Drawing.Point(364, 27);
            this.pictureBoxGalge.Name = "pictureBoxGalge";
            this.pictureBoxGalge.Size = new System.Drawing.Size(170, 205);
            this.pictureBoxGalge.TabIndex = 0;
            this.pictureBoxGalge.TabStop = false;
            // 
            // textBoxShowScore
            // 
            this.textBoxShowScore.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxShowScore.Location = new System.Drawing.Point(12, 12);
            this.textBoxShowScore.Name = "textBoxShowScore";
            this.textBoxShowScore.ReadOnly = true;
            this.textBoxShowScore.Size = new System.Drawing.Size(280, 38);
            this.textBoxShowScore.TabIndex = 1;
            this.textBoxShowScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxShowLife
            // 
            this.textBoxShowLife.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxShowLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxShowLife.Location = new System.Drawing.Point(12, 85);
            this.textBoxShowLife.Name = "textBoxShowLife";
            this.textBoxShowLife.ReadOnly = true;
            this.textBoxShowLife.Size = new System.Drawing.Size(280, 38);
            this.textBoxShowLife.TabIndex = 2;
            this.textBoxShowLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxShowWord
            // 
            this.textBoxShowWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxShowWord.Location = new System.Drawing.Point(12, 166);
            this.textBoxShowWord.Name = "textBoxShowWord";
            this.textBoxShowWord.Size = new System.Drawing.Size(280, 35);
            this.textBoxShowWord.TabIndex = 3;
            this.textBoxShowWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(531, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxShowHiddenWord
            // 
            this.textBoxShowHiddenWord.BackColor = System.Drawing.Color.White;
            this.textBoxShowHiddenWord.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxShowHiddenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxShowHiddenWord.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxShowHiddenWord.Location = new System.Drawing.Point(305, 239);
            this.textBoxShowHiddenWord.Name = "textBoxShowHiddenWord";
            this.textBoxShowHiddenWord.ReadOnly = true;
            this.textBoxShowHiddenWord.Size = new System.Drawing.Size(256, 38);
            this.textBoxShowHiddenWord.TabIndex = 30;
            this.textBoxShowHiddenWord.Text = "XXXXX";
            this.textBoxShowHiddenWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "E";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(369, 348);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "F";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(450, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 32;
            this.button7.Text = "G";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(531, 348);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 31;
            this.button8.Text = "H";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(288, 377);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 38;
            this.button9.Text = "I";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(369, 377);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 37;
            this.button10.Text = "J";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(450, 377);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 36;
            this.button11.Text = "K";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(531, 377);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 35;
            this.button12.Text = "L";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(288, 406);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 42;
            this.button13.Text = "M";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(369, 406);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 41;
            this.button14.Text = "N";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(450, 406);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 40;
            this.button15.Text = "O";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(531, 406);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 39;
            this.button16.Text = "P";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(288, 435);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 46;
            this.button17.Text = "Q";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(369, 435);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 45;
            this.button18.Text = "R";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(450, 435);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 44;
            this.button19.Text = "S";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(531, 435);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 43;
            this.button20.Text = "T";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(288, 464);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 50;
            this.button21.Text = "U";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(369, 464);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 49;
            this.button22.Text = "V";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(450, 464);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 48;
            this.button23.Text = "W";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(531, 464);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 47;
            this.button24.Text = "X";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(369, 493);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 52;
            this.button25.Text = "Y";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(450, 493);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 51;
            this.button26.Text = "Z";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxShowUsedLetters
            // 
            this.textBoxShowUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxShowUsedLetters.Location = new System.Drawing.Point(673, 166);
            this.textBoxShowUsedLetters.Name = "textBoxShowUsedLetters";
            this.textBoxShowUsedLetters.Size = new System.Drawing.Size(199, 45);
            this.textBoxShowUsedLetters.TabIndex = 53;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(692, 218);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(149, 23);
            this.button28.TabIndex = 55;
            this.button28.Text = "ShowUsedLetters";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // textBoxRoundShow
            // 
            this.textBoxRoundShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxRoundShow.Location = new System.Drawing.Point(673, 38);
            this.textBoxRoundShow.Name = "textBoxRoundShow";
            this.textBoxRoundShow.Size = new System.Drawing.Size(199, 45);
            this.textBoxRoundShow.TabIndex = 56;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 569);
            this.Controls.Add(this.textBoxRoundShow);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.textBoxShowUsedLetters);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBoxShowHiddenWord);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxShowWord);
            this.Controls.Add(this.textBoxShowLife);
            this.Controls.Add(this.textBoxShowScore);
            this.Controls.Add(this.pictureBoxGalge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGalge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGalge;
        private System.Windows.Forms.TextBox textBoxShowScore;
        private System.Windows.Forms.TextBox textBoxShowLife;
        private System.Windows.Forms.TextBox textBoxShowWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxShowHiddenWord;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox textBoxShowUsedLetters;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.TextBox textBoxRoundShow;
    }
}
