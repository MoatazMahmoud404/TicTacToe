using Shade.Controls;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ProjectFullPackage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true; // Enable key events for the form
            this.KeyDown += Form1_KeyDown; // Subscribe to the KeyDown event
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            timer2.Stop(); // Stop the timer2
            label1.Visible = true; // Make the label visible after 5 seconds


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Check if the pressed key is ESC
            {
                // Handle skipping here
                pictureBox2.Visible = false;
                label1.Visible = true; // Make the label visible after 5 seconds
                timer1.Stop();
                timer2.Stop();
            }
        }
        void Soundintro()
        {
            using (var soundStream = Properties.Resources.intro)
            {
                using (var soundPlayer = new SoundPlayer(soundStream))
                {
                    soundPlayer.Play();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            Soundintro();
            timer1.Start();
            timer2.Start();
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            timer1.Stop();
        }

        private void parrotSuperButton1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            parrotSuperButton1.Visible = false;

            OpenChildForm(new ChooseShape02());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog();
        }
    }
}
