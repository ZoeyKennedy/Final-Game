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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrizeSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrizeLong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.RosyBrown;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(249, 73);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(289, 44);
            this.txtInput.TabIndex = 0;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Segoe Script", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblPrompt.Location = new System.Drawing.Point(66, 160);
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
            this.btnGuess.Location = new System.Drawing.Point(332, 334);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(125, 82);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblTextInstructions
            // 
            this.lblTextInstructions.AutoSize = true;
            this.lblTextInstructions.Font = new System.Drawing.Font("Segoe Script", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblTextInstructions.Location = new System.Drawing.Point(54, 35);
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
            this.lblGuessesRemaining.Location = new System.Drawing.Point(318, 419);
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
            this.btnClose.Location = new System.Drawing.Point(293, 258);
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
            this.lblSecretNumber.Location = new System.Drawing.Point(63, 357);
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
            this.lblLine2.Location = new System.Drawing.Point(82, 199);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(79, 28);
            this.lblLine2.TabIndex = 28;
            this.lblLine2.Text = "prompt";
            this.lblLine2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Game.Properties.Resources.RIGHT;
            this.pictureBox1.Location = new System.Drawing.Point(768, -7);
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
            this.imgPrizeSquare.Location = new System.Drawing.Point(573, 160);
            this.imgPrizeSquare.Name = "imgPrizeSquare";
            this.imgPrizeSquare.Size = new System.Drawing.Size(201, 180);
            this.imgPrizeSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPrizeSquare.TabIndex = 8;
            this.imgPrizeSquare.TabStop = false;
            // 
            // imgPrizeLong
            // 
            this.imgPrizeLong.Location = new System.Drawing.Point(573, 91);
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
            this.label1.Location = new System.Drawing.Point(57, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "here is a secret number betw";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}