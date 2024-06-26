namespace Final_Game
{
    partial class Tops
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
            this.radShirt1 = new System.Windows.Forms.RadioButton();
            this.radShirt2 = new System.Windows.Forms.RadioButton();
            this.radShirt3 = new System.Windows.Forms.RadioButton();
            this.tadShirt4 = new System.Windows.Forms.RadioButton();
            this.grpTops = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpTops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radShirt1
            // 
            this.radShirt1.AutoSize = true;
            this.radShirt1.Location = new System.Drawing.Point(6, 42);
            this.radShirt1.Name = "radShirt1";
            this.radShirt1.Size = new System.Drawing.Size(14, 13);
            this.radShirt1.TabIndex = 0;
            this.radShirt1.TabStop = true;
            this.radShirt1.UseVisualStyleBackColor = true;
            this.radShirt1.CheckedChanged += new System.EventHandler(this.radShirt1_CheckedChanged);
            // 
            // radShirt2
            // 
            this.radShirt2.AutoSize = true;
            this.radShirt2.Location = new System.Drawing.Point(6, 171);
            this.radShirt2.Name = "radShirt2";
            this.radShirt2.Size = new System.Drawing.Size(14, 13);
            this.radShirt2.TabIndex = 1;
            this.radShirt2.TabStop = true;
            this.radShirt2.UseVisualStyleBackColor = true;
            this.radShirt2.CheckedChanged += new System.EventHandler(this.radShirt2_CheckedChanged);
            // 
            // radShirt3
            // 
            this.radShirt3.AutoSize = true;
            this.radShirt3.Location = new System.Drawing.Point(6, 292);
            this.radShirt3.Name = "radShirt3";
            this.radShirt3.Size = new System.Drawing.Size(14, 13);
            this.radShirt3.TabIndex = 2;
            this.radShirt3.TabStop = true;
            this.radShirt3.UseVisualStyleBackColor = true;
            this.radShirt3.CheckedChanged += new System.EventHandler(this.radShirt3_CheckedChanged);
            // 
            // tadShirt4
            // 
            this.tadShirt4.AutoSize = true;
            this.tadShirt4.Location = new System.Drawing.Point(6, 408);
            this.tadShirt4.Name = "tadShirt4";
            this.tadShirt4.Size = new System.Drawing.Size(14, 13);
            this.tadShirt4.TabIndex = 3;
            this.tadShirt4.TabStop = true;
            this.tadShirt4.UseVisualStyleBackColor = true;
            this.tadShirt4.CheckedChanged += new System.EventHandler(this.tadShirt4_CheckedChanged);
            // 
            // grpTops
            // 
            this.grpTops.BackColor = System.Drawing.Color.Thistle;
            this.grpTops.Controls.Add(this.tadShirt4);
            this.grpTops.Controls.Add(this.radShirt1);
            this.grpTops.Controls.Add(this.radShirt2);
            this.grpTops.Controls.Add(this.radShirt3);
            this.grpTops.Location = new System.Drawing.Point(109, 30);
            this.grpTops.Name = "grpTops";
            this.grpTops.Size = new System.Drawing.Size(29, 457);
            this.grpTops.TabIndex = 4;
            this.grpTops.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Game.Properties.Resources.shirt1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Final_Game.Properties.Resources.shirt4;
            this.pictureBox4.Location = new System.Drawing.Point(10, 394);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Game.Properties.Resources.shirt3;
            this.pictureBox3.Location = new System.Drawing.Point(10, 277);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Game.Properties.Resources.shirt2;
            this.pictureBox2.Location = new System.Drawing.Point(10, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Tops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(138, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpTops);
            this.Name = "Tops";
            this.Text = "Tops";
            this.grpTops.ResumeLayout(false);
            this.grpTops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radShirt1;
        private System.Windows.Forms.RadioButton radShirt2;
        private System.Windows.Forms.RadioButton radShirt3;
        private System.Windows.Forms.RadioButton tadShirt4;
        private System.Windows.Forms.GroupBox grpTops;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}