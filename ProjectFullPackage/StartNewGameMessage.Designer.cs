
namespace ProjectFullPackage
{
    partial class StartNewGameMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartNewGameMessage));
            this.PanelTitlebar = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.RoundCorner = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnYes = new Guna.UI2.WinForms.Guna2Button();
            this.BtnNo = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.PanelTitlebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelTitlebar.Name = "PanelTitlebar";
            this.PanelTitlebar.Size = new System.Drawing.Size(514, 37);
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
            this.AppName.Size = new System.Drawing.Size(479, 37);
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
            this.AppIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to Start New Game ?";
            // 
            // BtnYes
            // 
            this.BtnYes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.BtnYes.BorderRadius = 20;
            this.BtnYes.BorderThickness = 3;
            this.BtnYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.BtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.Location = new System.Drawing.Point(40, 163);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.PressedColor = System.Drawing.Color.Transparent;
            this.BtnYes.Size = new System.Drawing.Size(187, 62);
            this.BtnYes.TabIndex = 6;
            this.BtnYes.Text = "YES";
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnNo.BorderRadius = 20;
            this.BtnNo.BorderThickness = 3;
            this.BtnNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.Location = new System.Drawing.Point(292, 163);
            this.BtnNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.PressedColor = System.Drawing.Color.Transparent;
            this.BtnNo.Size = new System.Drawing.Size(187, 62);
            this.BtnNo.TabIndex = 7;
            this.BtnNo.Text = "NO";
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "No one wins !!";
            // 
            // StartNewGameMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(514, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartNewGameMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start New Game";
            this.PanelTitlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI2.WinForms.Guna2Button BtnYes;
        private Guna.UI2.WinForms.Guna2Button BtnNo;
        private System.Windows.Forms.Label label2;
    }
}