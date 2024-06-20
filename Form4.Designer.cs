namespace Final_Game
{
    partial class Form4
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imgUnlockedAccessories = new System.Windows.Forms.PictureBox();
            this.radGlassesV2 = new System.Windows.Forms.RadioButton();
            this.radHat = new System.Windows.Forms.RadioButton();
            this.radHairClip = new System.Windows.Forms.RadioButton();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.radUnlockedAccessories = new System.Windows.Forms.RadioButton();
            this.btnBottom = new System.Windows.Forms.Button();
            this.radNoAccessories = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUnlockedAccessories)).BeginInit();
            this.grpAccessories.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Game.Properties.Resources.hat;
            this.pictureBox2.Location = new System.Drawing.Point(2, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Game.Properties.Resources.glassesV2;
            this.pictureBox1.Location = new System.Drawing.Point(-15, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Game.Properties.Resources.hairclip;
            this.pictureBox3.Location = new System.Drawing.Point(-149, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(286, 192);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // imgUnlockedAccessories
            // 
            this.imgUnlockedAccessories.Location = new System.Drawing.Point(6, 334);
            this.imgUnlockedAccessories.Name = "imgUnlockedAccessories";
            this.imgUnlockedAccessories.Size = new System.Drawing.Size(131, 120);
            this.imgUnlockedAccessories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUnlockedAccessories.TabIndex = 3;
            this.imgUnlockedAccessories.TabStop = false;
            // 
            // radGlassesV2
            // 
            this.radGlassesV2.AutoSize = true;
            this.radGlassesV2.Location = new System.Drawing.Point(7, 82);
            this.radGlassesV2.Name = "radGlassesV2";
            this.radGlassesV2.Size = new System.Drawing.Size(14, 13);
            this.radGlassesV2.TabIndex = 4;
            this.radGlassesV2.TabStop = true;
            this.radGlassesV2.UseVisualStyleBackColor = true;
            this.radGlassesV2.CheckedChanged += new System.EventHandler(this.radGlassesV2_CheckedChanged);
            // 
            // radHat
            // 
            this.radHat.AutoSize = true;
            this.radHat.Location = new System.Drawing.Point(7, 180);
            this.radHat.Name = "radHat";
            this.radHat.Size = new System.Drawing.Size(14, 13);
            this.radHat.TabIndex = 5;
            this.radHat.TabStop = true;
            this.radHat.UseVisualStyleBackColor = true;
            this.radHat.CheckedChanged += new System.EventHandler(this.radHat_CheckedChanged);
            // 
            // radHairClip
            // 
            this.radHairClip.AutoSize = true;
            this.radHairClip.Location = new System.Drawing.Point(6, 279);
            this.radHairClip.Name = "radHairClip";
            this.radHairClip.Size = new System.Drawing.Size(14, 13);
            this.radHairClip.TabIndex = 6;
            this.radHairClip.TabStop = true;
            this.radHairClip.UseVisualStyleBackColor = true;
            this.radHairClip.CheckedChanged += new System.EventHandler(this.radHairClip_CheckedChanged);
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.radNoAccessories);
            this.grpAccessories.Controls.Add(this.radUnlockedAccessories);
            this.grpAccessories.Controls.Add(this.radHairClip);
            this.grpAccessories.Controls.Add(this.radHat);
            this.grpAccessories.Controls.Add(this.radGlassesV2);
            this.grpAccessories.ForeColor = System.Drawing.Color.AliceBlue;
            this.grpAccessories.Location = new System.Drawing.Point(136, 12);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(31, 404);
            this.grpAccessories.TabIndex = 7;
            this.grpAccessories.TabStop = false;
            // 
            // radUnlockedAccessories
            // 
            this.radUnlockedAccessories.AutoSize = true;
            this.radUnlockedAccessories.Location = new System.Drawing.Point(7, 385);
            this.radUnlockedAccessories.Name = "radUnlockedAccessories";
            this.radUnlockedAccessories.Size = new System.Drawing.Size(14, 13);
            this.radUnlockedAccessories.TabIndex = 8;
            this.radUnlockedAccessories.TabStop = true;
            this.radUnlockedAccessories.UseVisualStyleBackColor = true;
            // 
            // btnBottom
            // 
            this.btnBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(165)))), ((int)(((byte)(188)))));
            this.btnBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBottom.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(22)))), ((int)(((byte)(6)))));
            this.btnBottom.Location = new System.Drawing.Point(3, 24);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(134, 41);
            this.btnBottom.TabIndex = 8;
            this.btnBottom.Text = "No Accessories";
            this.btnBottom.UseVisualStyleBackColor = false;
            // 
            // radNoAccessories
            // 
            this.radNoAccessories.AutoSize = true;
            this.radNoAccessories.Location = new System.Drawing.Point(8, 25);
            this.radNoAccessories.Name = "radNoAccessories";
            this.radNoAccessories.Size = new System.Drawing.Size(14, 13);
            this.radNoAccessories.TabIndex = 9;
            this.radNoAccessories.TabStop = true;
            this.radNoAccessories.UseVisualStyleBackColor = true;
            this.radNoAccessories.CheckedChanged += new System.EventHandler(this.radNoAccessories_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(167, 450);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.imgUnlockedAccessories);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUnlockedAccessories)).EndInit();
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox imgUnlockedAccessories;
        private System.Windows.Forms.RadioButton radGlassesV2;
        private System.Windows.Forms.RadioButton radHat;
        private System.Windows.Forms.RadioButton radHairClip;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.RadioButton radUnlockedAccessories;
        private System.Windows.Forms.RadioButton radNoAccessories;
        private System.Windows.Forms.Button btnBottom;
    }
}