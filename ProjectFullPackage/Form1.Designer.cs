namespace ProjectFullPackage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.parrotSuperButton1 = new Shade.Controls.ParrotSuperButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 104);
            this.label1.TabIndex = 135;
            this.label1.Text = "Are You Ready ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 22400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ControlBox1.CustomClick = true;
            this.guna2ControlBox1.CustomIconSize = 30F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1488, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(70, 50);
            this.guna2ControlBox1.TabIndex = 136;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 900);
            this.panel1.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 759);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1045, 74);
            this.label2.TabIndex = 138;
            this.label2.Text = "Created With <3 By 0xMoataz - © Copy Right 2024";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1600, 900);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // parrotSuperButton1
            // 
            this.parrotSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotSuperButton1.ButtonImage")));
            this.parrotSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.parrotSuperButton1.ButtonStyle = Shade.Controls.ParrotSuperButton.Style.RoundedEdges;
            this.parrotSuperButton1.ButtonText = "Play";
            this.parrotSuperButton1.CornerRadius = 10;
            this.parrotSuperButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotSuperButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.parrotSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotSuperButton1.HoverBackgroundColor = System.Drawing.Color.LimeGreen;
            this.parrotSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.parrotSuperButton1.ImagePosition = Shade.Controls.ParrotSuperButton.ImgPosition.Left;
            this.parrotSuperButton1.Location = new System.Drawing.Point(715, 503);
            this.parrotSuperButton1.Name = "parrotSuperButton1";
            this.parrotSuperButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.parrotSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.parrotSuperButton1.Size = new System.Drawing.Size(171, 54);
            this.parrotSuperButton1.SuperSelected = false;
            this.parrotSuperButton1.TabIndex = 134;
            this.parrotSuperButton1.TextColor = System.Drawing.Color.White;
            this.parrotSuperButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotSuperButton1.Click += new System.EventHandler(this.parrotSuperButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parrotSuperButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private Shade.Controls.ParrotSuperButton parrotSuperButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
    }
}

