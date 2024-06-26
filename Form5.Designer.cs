namespace Final_Game
{
    partial class Form5
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblTextInstructions = new System.Windows.Forms.Label();
            this.lblGuessesRemaining = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSecretNumber = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.imgPrizeSquare = new System.Windows.Forms.PictureBox();
            this.imgPrizeLong = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrizeSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrizeLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.RosyBrown;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(186, 122);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(289, 44);
            this.txtInput.TabIndex = 0;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Segoe Script", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblPrompt.Location = new System.Drawing.Point(92, 170);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(79, 28);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "prompt";
            this.lblPrompt.Click += new System.EventHandler(this.lblPrompt_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(165)))), ((int)(((byte)(188)))));
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuess.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(234, 220);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(191, 163);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblTextInstructions
            // 
            this.lblTextInstructions.AutoSize = true;
            this.lblTextInstructions.Font = new System.Drawing.Font("Segoe Script", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblTextInstructions.Location = new System.Drawing.Point(31, 82);
            this.lblTextInstructions.Name = "lblTextInstructions";
            this.lblTextInstructions.Size = new System.Drawing.Size(686, 22);
            this.lblTextInstructions.TabIndex = 3;
            this.lblTextInstructions.Text = "Type your guess into the textbox below, then click the \"Guess\" button to submit y" +
    "our guess";
            // 
            // lblGuessesRemaining
            // 
            this.lblGuessesRemaining.AutoSize = true;
            this.lblGuessesRemaining.Font = new System.Drawing.Font("Segoe Script", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblGuessesRemaining.Location = new System.Drawing.Point(256, 386);
            this.lblGuessesRemaining.Name = "lblGuessesRemaining";
            this.lblGuessesRemaining.Size = new System.Drawing.Size(154, 22);
            this.lblGuessesRemaining.TabIndex = 4;
            this.lblGuessesRemaining.Text = "remaining guesses: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(165)))), ((int)(((byte)(188)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(225, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(209, 82);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSecretNumber
            // 
            this.lblSecretNumber.AutoSize = true;
            this.lblSecretNumber.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretNumber.Location = new System.Drawing.Point(72, 301);
            this.lblSecretNumber.Name = "lblSecretNumber";
            this.lblSecretNumber.Size = new System.Drawing.Size(109, 44);
            this.lblSecretNumber.TabIndex = 7;
            this.lblSecretNumber.Text = "label1";
            this.lblSecretNumber.Visible = false;
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Font = new System.Drawing.Font("Segoe Script", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblLine2.Location = new System.Drawing.Point(92, 198);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(0, 28);
            this.lblLine2.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Game.Properties.Resources.RIGHT;
            this.pictureBox1.Location = new System.Drawing.Point(723, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Final_Game.Properties.Resources.LEFT;
            this.pictureBox6.Location = new System.Drawing.Point(1, -11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 468);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // imgPrizeSquare
            // 
            this.imgPrizeSquare.Location = new System.Drawing.Point(502, 187);
            this.imgPrizeSquare.Name = "imgPrizeSquare";
            this.imgPrizeSquare.Size = new System.Drawing.Size(201, 180);
            this.imgPrizeSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPrizeSquare.TabIndex = 8;
            this.imgPrizeSquare.TabStop = false;
            // 
            // imgPrizeLong
            // 
            this.imgPrizeLong.Location = new System.Drawing.Point(502, 118);
            this.imgPrizeLong.Name = "imgPrizeLong";
            this.imgPrizeLong.Size = new System.Drawing.Size(201, 306);
            this.imgPrizeLong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPrizeLong.TabIndex = 6;
            this.imgPrizeLong.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "There is a secret number between 1 and 30. If you can correctly guess the number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(170, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "within 5 guesses, you will win a new accessory!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Game.Properties.Resources.UPPER;
            this.pictureBox3.Location = new System.Drawing.Point(39, -7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(655, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Game.Properties.Resources.UPPER;
            this.pictureBox2.Location = new System.Drawing.Point(578, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(655, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Final_Game.Properties.Resources.LOWER;
            this.pictureBox4.Location = new System.Drawing.Point(1, 426);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(655, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Final_Game.Properties.Resources.LOWER;
            this.pictureBox5.Location = new System.Drawing.Point(486, 426);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(655, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.imgPrizeSquare);
            this.Controls.Add(this.lblSecretNumber);
            this.Controls.Add(this.imgPrizeLong);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGuessesRemaining);
            this.Controls.Add(this.lblTextInstructions);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(22)))), ((int)(((byte)(6)))));
            this.Name = "Form5";
            this.Text = "Minigame";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrizeSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrizeLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblTextInstructions;
        private System.Windows.Forms.Label lblGuessesRemaining;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox imgPrizeLong;
        private System.Windows.Forms.Label lblSecretNumber;
        private System.Windows.Forms.PictureBox imgPrizeSquare;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}