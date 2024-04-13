using Shade.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFullPackage
{
    public partial class ChooseShape02 : Form
    {
        private Game gameForm;

        void Soundlong()
        {
            using (var soundStream = Properties.Resources.backgroundSoundPlayer)
            {
                using (var soundPlayer = new SoundPlayer(soundStream))
                {
                    soundPlayer.PlayLooping();
                }
            }
        }
        public ChooseShape02()
        {
            InitializeComponent();
            Soundlong();
        }

        private void ChooseShape02_Load(object sender, EventArgs e)
        {
            skyLabel1.Parent = pictureBox1;
            skyLabel1.BackColor = Color.Transparent;
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Yourname gameName = new Yourname();
            gameName.ShowDialog();
            if (!string.IsNullOrEmpty(gameName.EnteredName))
            {
                OpenGameForm("X", gameName.EnteredName);
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Yourname gameName = new Yourname();
            gameName.ShowDialog();
            if (!string.IsNullOrEmpty(gameName.EnteredName))
            {
                OpenGameForm("O", gameName.EnteredName);
            }
        }

        private void OpenGameForm(string ch, string playerName)
        {
            if (gameForm == null || gameForm.IsDisposed)
            {
                gameForm = new Game();
                gameForm.TopLevel = false;
                gameForm.FormBorderStyle = FormBorderStyle.None;
                string chosenShape = ch;
                gameForm.SetChosenShape(chosenShape);
                gameForm.SetPlayerName(playerName);
                gameForm.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(gameForm);
                gameForm.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog();
        }
    }
}
