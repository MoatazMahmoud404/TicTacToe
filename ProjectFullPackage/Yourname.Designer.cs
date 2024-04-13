
namespace ProjectFullPackage
{
    partial class Yourname
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yourname));
            this.PanelTitlebar = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.RoundCorner = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bigTextBox1 = new Shade.Controls.BigTextBox();
            this.BtnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.PanelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitlebar
            // 
            this.PanelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelTitlebar.Controls.Add(this.AppName);
            this.PanelTitlebar.Controls.Add(this.AppIcon);
            this.PanelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitlebar.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTitlebar.Name = "PanelTitlebar";
            this.PanelTitlebar.Size = new System.Drawing.Size(662, 37);
            this.PanelTitlebar.TabIndex = 1;
            // 
            // AppName
            // 
            this.AppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(35, 0);
            this.AppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(627, 37);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "Start New Game";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppIcon
            // 
            this.AppIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppIcon.ErrorImage = null;
            this.AppIcon.Image = global::ProjectFullPackage.Properties.Resources.TicTacToe;
            this.AppIcon.InitialImage = null;
            this.AppIcon.Location = new System.Drawing.Point(0, 0);
            this.AppIcon.Margin = new System.Windows.Forms.Padding(4);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(35, 37);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppIcon.TabIndex = 0;
            this.AppIcon.TabStop = false;
            // 
            // RoundCorner
            // 
            this.RoundCorner.BorderRadius = 16;
            this.RoundCorner.TargetControl = this;
            // 
            // DragControl1
            // 
            this.DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1.TargetControl = this.AppIcon;
            this.DragControl1.UseTransparentDrag = true;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.AppName;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // DragControl3
            // 
            this.DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl3.TargetControl = this;
            this.DragControl3.UseTransparentDrag = true;
            // 
            // DragControl4
            // 
            this.DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl4.TargetControl = this.label1;
            this.DragControl4.UseTransparentDrag = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigTextBox1
            // 
            this.bigTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bigTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.bigTextBox1.Image = null;
            this.bigTextBox1.Location = new System.Drawing.Point(172, 171);
            this.bigTextBox1.MaxLength = 32767;
            this.bigTextBox1.Multiline = false;
            this.bigTextBox1.Name = "bigTextBox1";
            this.bigTextBox1.ReadOnly = false;
            this.bigTextBox1.Size = new System.Drawing.Size(319, 47);
            this.bigTextBox1.TabIndex = 8;
            this.bigTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bigTextBox1.UseSystemPasswordChar = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.BorderRadius = 20;
            this.BtnSubmit.BorderThickness = 3;
            this.BtnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(230, 255);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.PressedColor = System.Drawing.Color.Transparent;
            this.BtnSubmit.Size = new System.Drawing.Size(198, 58);
            this.BtnSubmit.TabIndex = 9;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // Yourname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(662, 372);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.bigTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Yourname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start New Game";
            this.PanelTitlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitlebar;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox AppIcon;
        private Guna.UI2.WinForms.Guna2Elipse RoundCorner;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl DragControl4;
        private System.Windows.Forms.Label label1;
        private Shade.Controls.BigTextBox bigTextBox1;
        private Guna.UI2.WinForms.Guna2Button BtnSubmit;
    }
}