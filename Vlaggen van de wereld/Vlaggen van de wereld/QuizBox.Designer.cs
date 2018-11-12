namespace Vlaggen_van_de_wereld
{
    partial class QuizBox
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
            this.FlagBox = new System.Windows.Forms.PictureBox();
            this.AwnserBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Answer_7 = new System.Windows.Forms.RadioButton();
            this.Answer_8 = new System.Windows.Forms.RadioButton();
            this.Answer_9 = new System.Windows.Forms.RadioButton();
            this.Answer_6 = new System.Windows.Forms.RadioButton();
            this.Answer_5 = new System.Windows.Forms.RadioButton();
            this.Answer_2 = new System.Windows.Forms.RadioButton();
            this.Answer_3 = new System.Windows.Forms.RadioButton();
            this.Answer_4 = new System.Windows.Forms.RadioButton();
            this.Answer_1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlagBox)).BeginInit();
            this.AwnserBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlagBox
            // 
            this.FlagBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlagBox.Location = new System.Drawing.Point(12, 12);
            this.FlagBox.Name = "FlagBox";
            this.FlagBox.Size = new System.Drawing.Size(458, 426);
            this.FlagBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FlagBox.TabIndex = 0;
            this.FlagBox.TabStop = false;
            // 
            // AwnserBox
            // 
            this.AwnserBox.Controls.Add(this.button4);
            this.AwnserBox.Controls.Add(this.button3);
            this.AwnserBox.Controls.Add(this.button2);
            this.AwnserBox.Controls.Add(this.button1);
            this.AwnserBox.Controls.Add(this.Answer_7);
            this.AwnserBox.Controls.Add(this.Answer_8);
            this.AwnserBox.Controls.Add(this.Answer_9);
            this.AwnserBox.Controls.Add(this.Answer_6);
            this.AwnserBox.Controls.Add(this.Answer_5);
            this.AwnserBox.Controls.Add(this.Answer_2);
            this.AwnserBox.Controls.Add(this.Answer_3);
            this.AwnserBox.Controls.Add(this.Answer_4);
            this.AwnserBox.Controls.Add(this.Answer_1);
            this.AwnserBox.Location = new System.Drawing.Point(476, 12);
            this.AwnserBox.Name = "AwnserBox";
            this.AwnserBox.Size = new System.Drawing.Size(549, 426);
            this.AwnserBox.TabIndex = 1;
            this.AwnserBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NextClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PreviousClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AcceptClick);
            // 
            // Answer_7
            // 
            this.Answer_7.AutoSize = true;
            this.Answer_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_7.Location = new System.Drawing.Point(7, 268);
            this.Answer_7.Name = "Answer_7";
            this.Answer_7.Size = new System.Drawing.Size(17, 16);
            this.Answer_7.TabIndex = 8;
            this.Answer_7.TabStop = true;
            this.Answer_7.UseVisualStyleBackColor = true;
            this.Answer_7.Click += new System.EventHandler(this.AwnserClick);
            // 
            // Answer_8
            // 
            this.Answer_8.AutoSize = true;
            this.Answer_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_8.Location = new System.Drawing.Point(7, 309);
            this.Answer_8.Name = "Answer_8";
            this.Answer_8.Size = new System.Drawing.Size(17, 16);
            this.Answer_8.TabIndex = 7;
            this.Answer_8.TabStop = true;
            this.Answer_8.UseVisualStyleBackColor = true;
            this.Answer_8.Click += new System.EventHandler(this.AwnserClick);
            // 
            // Answer_9
            // 
            this.Answer_9.AutoSize = true;
            this.Answer_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_9.Location = new System.Drawing.Point(7, 350);
            this.Answer_9.Name = "Answer_9";
            this.Answer_9.Size = new System.Drawing.Size(17, 16);
            this.Answer_9.TabIndex = 6;
            this.Answer_9.TabStop = true;
            this.Answer_9.UseVisualStyleBackColor = true;
            this.Answer_9.Click += new System.EventHandler(this.AwnserClick);
            // 
            // Answer_6
            // 
            this.Answer_6.AutoSize = true;
            this.Answer_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_6.Location = new System.Drawing.Point(7, 227);
            this.Answer_6.Name = "Answer_6";
            this.Answer_6.Size = new System.Drawing.Size(17, 16);
            this.Answer_6.TabIndex = 5;
            this.Answer_6.TabStop = true;
            this.Answer_6.UseVisualStyleBackColor = true;
            this.Answer_6.Click += new System.EventHandler(this.AwnserClick);
            // 
            // Answer_5
            // 
            this.Answer_5.AutoSize = true;
            this.Answer_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_5.Location = new System.Drawing.Point(7, 186);
            this.Answer_5.Name = "Answer_5";
            this.Answer_5.Size = new System.Drawing.Size(17, 16);
            this.Answer_5.TabIndex = 4;
            this.Answer_5.TabStop = true;
            this.Answer_5.UseVisualStyleBackColor = true;
            this.Answer_5.Click += new System.EventHandler(this.AwnserClick);
            // 
            // Answer_2
            // 
            this.Answer_2.AutoSize = true;
            this.Answer_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_2.Location = new System.Drawing.Point(7, 63);
            this.Answer_2.Name = "Answer_2";
            this.Answer_2.Size = new System.Drawing.Size(17, 16);
            this.Answer_2.TabIndex = 3;
            this.Answer_2.TabStop = true;
            this.Answer_2.UseVisualStyleBackColor = true;
            this.Answer_2.Click += new System.EventHandler(this.AwnserClick);
            // 
            // Answer_3
            // 
            this.Answer_3.AutoSize = true;
            this.Answer_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_3.Location = new System.Drawing.Point(7, 104);
            this.Answer_3.Name = "Answer_3";
            this.Answer_3.Size = new System.Drawing.Size(17, 16);
            this.Answer_3.TabIndex = 2;
            this.Answer_3.TabStop = true;
            this.Answer_3.UseVisualStyleBackColor = true;
            this.Answer_3.Click += new System.EventHandler(this.AwnserClick);
            // 
            // Answer_4
            // 
            this.Answer_4.AutoSize = true;
            this.Answer_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_4.Location = new System.Drawing.Point(7, 145);
            this.Answer_4.Name = "Answer_4";
            this.Answer_4.Size = new System.Drawing.Size(17, 16);
            this.Answer_4.TabIndex = 1;
            this.Answer_4.TabStop = true;
            this.Answer_4.UseVisualStyleBackColor = true;
            this.Answer_4.Click += new System.EventHandler(this.AwnserClick);
            // 
            // Answer_1
            // 
            this.Answer_1.AutoSize = true;
            this.Answer_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Answer_1.Location = new System.Drawing.Point(7, 22);
            this.Answer_1.Name = "Answer_1";
            this.Answer_1.Size = new System.Drawing.Size(17, 16);
            this.Answer_1.TabIndex = 0;
            this.Answer_1.TabStop = true;
            this.Answer_1.UseVisualStyleBackColor = true;
            this.Answer_1.Click += new System.EventHandler(this.AwnserClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(402, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "Done";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DoneClick);
            // 
            // QuizBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.AwnserBox);
            this.Controls.Add(this.FlagBox);
            this.Name = "QuizBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuizBoxLoad);
            ((System.ComponentModel.ISupportInitialize)(this.FlagBox)).EndInit();
            this.AwnserBox.ResumeLayout(false);
            this.AwnserBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FlagBox;
        private System.Windows.Forms.GroupBox AwnserBox;
        private System.Windows.Forms.RadioButton Answer_2;
        private System.Windows.Forms.RadioButton Answer_3;
        private System.Windows.Forms.RadioButton Answer_4;
        private System.Windows.Forms.RadioButton Answer_7;
        private System.Windows.Forms.RadioButton Answer_8;
        private System.Windows.Forms.RadioButton Answer_9;
        private System.Windows.Forms.RadioButton Answer_6;
        private System.Windows.Forms.RadioButton Answer_5;
        private System.Windows.Forms.RadioButton Answer_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

