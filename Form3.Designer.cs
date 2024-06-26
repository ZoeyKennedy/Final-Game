namespace Final_Game
{
    partial class Shoes
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
            this.imgchooseshoe3 = new System.Windows.Forms.PictureBox();
            this.imgchooseShoe = new System.Windows.Forms.PictureBox();
            this.imgchooseshoe2 = new System.Windows.Forms.PictureBox();
            this.radShoe1 = new System.Windows.Forms.RadioButton();
            this.radshoe2 = new System.Windows.Forms.RadioButton();
            this.radshoe3 = new System.Windows.Forms.RadioButton();
            this.grpShoes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgchooseshoe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgchooseShoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgchooseshoe2)).BeginInit();
            this.grpShoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgchooseshoe3
            // 
            this.imgchooseshoe3.Image = global::Final_Game.Properties.Resources.croppedshoes3;
            this.imgchooseshoe3.Location = new System.Drawing.Point(12, 327);
            this.imgchooseshoe3.Name = "imgchooseshoe3";
            this.imgchooseshoe3.Size = new System.Drawing.Size(154, 132);
            this.imgchooseshoe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgchooseshoe3.TabIndex = 2;
            this.imgchooseshoe3.TabStop = false;
            // 
            // imgchooseShoe
            // 
            this.imgchooseShoe.Image = global::Final_Game.Properties.Resources.croppedshoes1;
            this.imgchooseShoe.Location = new System.Drawing.Point(12, 16);
            this.imgchooseShoe.Name = "imgchooseShoe";
            this.imgchooseShoe.Size = new System.Drawing.Size(154, 132);
            this.imgchooseShoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgchooseShoe.TabIndex = 1;
            this.imgchooseShoe.TabStop = false;
            // 
            // imgchooseshoe2
            // 
            this.imgchooseshoe2.Image = global::Final_Game.Properties.Resources.croppedshoes2;
            this.imgchooseshoe2.Location = new System.Drawing.Point(12, 173);
            this.imgchooseshoe2.Name = "imgchooseshoe2";
            this.imgchooseshoe2.Size = new System.Drawing.Size(154, 132);
            this.imgchooseshoe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgchooseshoe2.TabIndex = 0;
            this.imgchooseshoe2.TabStop = false;
            // 
            // radShoe1
            // 
            this.radShoe1.AutoSize = true;
            this.radShoe1.Location = new System.Drawing.Point(11, 62);
            this.radShoe1.Name = "radShoe1";
            this.radShoe1.Size = new System.Drawing.Size(14, 13);
            this.radShoe1.TabIndex = 3;
            this.radShoe1.TabStop = true;
            this.radShoe1.UseVisualStyleBackColor = true;
            this.radShoe1.CheckedChanged += new System.EventHandler(this.radShoe1_CheckedChanged);
            // 
            // radshoe2
            // 
            this.radshoe2.AutoSize = true;
            this.radshoe2.Location = new System.Drawing.Point(11, 214);
            this.radshoe2.Name = "radshoe2";
            this.radshoe2.Size = new System.Drawing.Size(14, 13);
            this.radshoe2.TabIndex = 4;
            this.radshoe2.TabStop = true;
            this.radshoe2.UseVisualStyleBackColor = true;
            this.radshoe2.CheckedChanged += new System.EventHandler(this.radshoe2_CheckedChanged);
            // 
            // radshoe3
            // 
            this.radshoe3.AutoSize = true;
            this.radshoe3.Location = new System.Drawing.Point(11, 379);
            this.radshoe3.Name = "radshoe3";
            this.radshoe3.Size = new System.Drawing.Size(14, 13);
            this.radshoe3.TabIndex = 5;
            this.radshoe3.TabStop = true;
            this.radshoe3.UseVisualStyleBackColor = true;
            this.radshoe3.CheckedChanged += new System.EventHandler(this.radshoe3_CheckedChanged);
            // 
            // grpShoes
            // 
            this.grpShoes.Controls.Add(this.radshoe3);
            this.grpShoes.Controls.Add(this.radshoe2);
            this.grpShoes.Controls.Add(this.radShoe1);
            this.grpShoes.Location = new System.Drawing.Point(179, 16);
            this.grpShoes.Name = "grpShoes";
            this.grpShoes.Size = new System.Drawing.Size(39, 443);
            this.grpShoes.TabIndex = 6;
            this.grpShoes.TabStop = false;
            // 
            // Shoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(232, 470);
            this.Controls.Add(this.grpShoes);
            this.Controls.Add(this.imgchooseshoe3);
            this.Controls.Add(this.imgchooseShoe);
            this.Controls.Add(this.imgchooseshoe2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(22)))), ((int)(((byte)(6)))));
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Shoes";
            this.Text = "Shoes";
            this.Load += new System.EventHandler(this.Shoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgchooseshoe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgchooseShoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgchooseshoe2)).EndInit();
            this.grpShoes.ResumeLayout(false);
            this.grpShoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgchooseshoe2;
        private System.Windows.Forms.PictureBox imgchooseShoe;
        private System.Windows.Forms.PictureBox imgchooseshoe3;
        private System.Windows.Forms.RadioButton radShoe1;
        private System.Windows.Forms.RadioButton radshoe2;
        private System.Windows.Forms.RadioButton radshoe3;
        private System.Windows.Forms.GroupBox grpShoes;
    }
}