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
            this.lblResults = new System.Windows.Forms.Label();
            this.lblGuessesRemaining = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.imgPrize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(118, 70);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(289, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(116, 136);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(39, 13);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "prompt";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(150, 239);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(125, 82);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(544, 200);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(37, 13);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "results";
            // 
            // lblGuessesRemaining
            // 
            this.lblGuessesRemaining.AutoSize = true;
            this.lblGuessesRemaining.Location = new System.Drawing.Point(396, 193);
            this.lblGuessesRemaining.Name = "lblGuessesRemaining";
            this.lblGuessesRemaining.Size = new System.Drawing.Size(100, 13);
            this.lblGuessesRemaining.TabIndex = 4;
            this.lblGuessesRemaining.Text = "remaining guesses: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(355, 291);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(209, 78);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imgPrize
            // 
            this.imgPrize.Location = new System.Drawing.Point(535, 26);
            this.imgPrize.Name = "imgPrize";
            this.imgPrize.Size = new System.Drawing.Size(201, 145);
            this.imgPrize.TabIndex = 6;
            this.imgPrize.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgPrize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGuessesRemaining);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtInput);
            this.Name = "Form5";
            this.Text = "Minigame";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPrize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblGuessesRemaining;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox imgPrize;
    }
}