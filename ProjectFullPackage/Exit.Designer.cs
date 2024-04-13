
namespace ProjectFullPackage
{
    partial class Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.BtnNo = new Guna.UI2.WinForms.Guna2Button();
            this.AppName = new System.Windows.Forms.Label();
            this.RoundCorner = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnYes = new Guna.UI2.WinForms.Guna2Button();
            this.PanelTitlebar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.PanelTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNo
            // 
            this.BtnNo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnNo.BorderRadius = 20;
            this.BtnNo.BorderThickness = 3;
            this.BtnNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.Location = new System.Drawing.Point(299, 132);
            this.BtnNo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.PressedColor = System.Drawing.Color.Transparent;
            this.BtnNo.Size = new System.Drawing.Size(187, 62);
            this.BtnNo.TabIndex = 11;
            this.BtnNo.Text = "NO";
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // AppName
            // 
            this.AppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(35, 0);
            this.AppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(497, 37);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "                      Exit";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Do you want to Exit Application ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnYes
            // 
            this.BtnYes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.BtnYes.BorderRadius = 20;
            this.BtnYes.BorderThickness = 3;
            this.BtnYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.BtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.Location = new System.Drawing.Point(47, 132);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.PressedColor = System.Drawing.Color.Transparent;
            this.BtnYes.Size = new System.Drawing.Size(187, 62);
            this.BtnYes.TabIndex = 10;
            this.BtnYes.Text = "YES";
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
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
            this.PanelTitlebar.Size = new System.Drawing.Size(532, 37);
            this.PanelTitlebar.TabIndex = 8;
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(532, 225);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.PanelTitlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnNo;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox AppIcon;
        private Guna.UI2.WinForms.Guna2Elipse RoundCorner;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl DragControl4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnYes;
        private System.Windows.Forms.Panel PanelTitlebar;
    }
}