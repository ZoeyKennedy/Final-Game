namespace Final_Game
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnViewTops = new System.Windows.Forms.Button();
            this.imgBottom = new System.Windows.Forms.PictureBox();
            this.imgTop = new System.Windows.Forms.PictureBox();
            this.imgPerson = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBottom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(32, 370);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(103, 65);
            this.btnButton.TabIndex = 3;
            this.btnButton.Text = "button1";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnViewTops
            // 
            this.btnViewTops.Location = new System.Drawing.Point(14, 26);
            this.btnViewTops.Name = "btnViewTops";
            this.btnViewTops.Size = new System.Drawing.Size(152, 41);
            this.btnViewTops.TabIndex = 4;
            this.btnViewTops.Text = "View Tops";
            this.btnViewTops.UseVisualStyleBackColor = true;
            this.btnViewTops.Click += new System.EventHandler(this.btnViewTops_Click);
            // 
            // imgBottom
            // 
            this.imgBottom.BackColor = System.Drawing.Color.Transparent;
            this.imgBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgBottom.Location = new System.Drawing.Point(166, 185);
            this.imgBottom.Name = "imgBottom";
            this.imgBottom.Size = new System.Drawing.Size(165, 277);
            this.imgBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBottom.TabIndex = 1;
            this.imgBottom.TabStop = false;
            this.imgBottom.Click += new System.EventHandler(this.imgBottom_Click);
            // 
            // imgTop
            // 
            this.imgTop.BackColor = System.Drawing.Color.Transparent;
            this.imgTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgTop.Location = new System.Drawing.Point(166, 115);
            this.imgTop.Name = "imgTop";
            this.imgTop.Size = new System.Drawing.Size(123, 99);
            this.imgTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTop.TabIndex = 2;
            this.imgTop.TabStop = false;
            this.imgTop.Click += new System.EventHandler(this.imgTop_Click);
            // 
            // imgPerson
            // 
            this.imgPerson.Image = ((System.Drawing.Image)(resources.GetObject("imgPerson.Image")));
            this.imgPerson.Location = new System.Drawing.Point(188, 12);
            this.imgPerson.Name = "imgPerson";
            this.imgPerson.Size = new System.Drawing.Size(449, 449);
            this.imgPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerson.TabIndex = 0;
            this.imgPerson.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(552, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 451);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(188, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 451);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(14, 89);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(152, 41);
            this.btnBottom.TabIndex = 7;
            this.btnBottom.Text = "View Bottoms";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(784, 474);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewTops);
            this.Controls.Add(this.imgBottom);
            this.Controls.Add(this.imgTop);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.imgPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPerson;
        private System.Windows.Forms.PictureBox imgBottom;
        public System.Windows.Forms.PictureBox imgTop;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnViewTops;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBottom;
    }
}

