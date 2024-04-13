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
using Guna.UI2.WinForms;
using Shade.Controls;

namespace ProjectFullPackage
{
    public partial class Game : Form
    {
        void SoundMultiply()
        {
            using (var soundStream = Properties.Resources.Multiply1)
            {
                using (var soundPlayer = new SoundPlayer(soundStream))
                {
                    soundPlayer.Play();
                }
            }
        }
        void SoundCircle()
        {
            using (var soundStream = Properties.Resources.Circle1)
            {
                using (var soundPlayer = new SoundPlayer(soundStream))
                {
                    soundPlayer.Play();
                }
            }
        }

        void Sounddoll1()
        {

            using (var soundStream = Properties.Resources.doll1)
            {
                using (var soundPlayer = new SoundPlayer(soundStream))
                {
                    soundPlayer.Play();
                }
            }
        }
        private SoundPlayer backgroundSoundPlayer;
        private void PlayBackgroundSound()
        {
            using (var soundStream = Properties.Resources.backgroundSoundPlayer)
            {
                using (var soundPlayer = new SoundPlayer(soundStream))
                {
                    soundPlayer.PlayLooping();
                }
            }
        }
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        List<Guna2Button> buttons;
        Random rand = new Random();
        int playerWins = 0;
        int computerWins = 0;
        bool playerTurn = true;
        private string chosenShape;
        private string playerName;
        public void SetChosenShape(string shape)
        {
            chosenShape = shape;
        }
        public void SetPlayerName(string name)
        {
            playerName = name;
            YouLabel.Text = name;
        }

        public Game()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            currentPlayer = Player.X;
        }

        private void PCmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0 && !playerTurn)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Text = (chosenShape == "X") ? Player.O.ToString() : Player.X.ToString();
                buttons[index].BackColor = Color.FromArgb(50, 50, 50);
                buttons[index].Enabled = false;
                buttons.RemoveAt(index);
                CheckGame();
                playerTurn = true;
                PCTimer.Stop();
                // SoundCircle();
            }
        }
        private void PlayerClickButton(object sender, EventArgs e)
        {
            if (!playerTurn)
                return;

            var button = (Guna2Button)sender;
            button.Text = chosenShape;
            button.FillColor = Color.FromArgb(50, 50, 50);
            button.Enabled = false;
            buttons.Remove(button);
            CheckGame();
            playerTurn = false;
            PCTimer.Start();
            // SoundMultiply();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            bool allButtonsClicked = buttons.All(button => !string.IsNullOrEmpty(button.Text));
            string opponentShape = chosenShape == "X" ? "O" : "X";

            if (Button01.Text == "X" && Button02.Text == "X" && Button03.Text == "X"
               || Button04.Text == "X" && Button05.Text == "X" && Button06.Text == "X"
               || Button07.Text == "X" && Button09.Text == "X" && Button08.Text == "X"
               || Button01.Text == "X" && Button04.Text == "X" && Button07.Text == "X"
               || Button02.Text == "X" && Button05.Text == "X" && Button08.Text == "X"
               || Button03.Text == "X" && Button06.Text == "X" && Button09.Text == "X"
               || Button01.Text == "X" && Button05.Text == "X" && Button09.Text == "X"
               || Button03.Text == "X" && Button05.Text == "X" && Button07.Text == "X")
            {
                if (chosenShape == "X")
                {
                    PCTimer.Stop();
                    MessageMultiply messagemultiply = new MessageMultiply(playerName);
                    messagemultiply.ShowDialog();
                    playerWins++;
                    YouLabel.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                    YouLabel.Text = $"{playerName} : " + playerWins;

                    RestartGame();
                }
                else
                {
                    PCTimer.Stop();
                    MessageMultiply messagemultiply = new MessageMultiply("PC");
                    messagemultiply.ShowDialog();
                    computerWins++;
                    PCLabel.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                    PCLabel.Text = "PC : " + computerWins;
                    RestartGame();
                }

            }

            else if (Button01.Text == "O" && Button02.Text == "O" && Button03.Text == "O"
            || Button04.Text == "O" && Button05.Text == "O" && Button06.Text == "O"
            || Button07.Text == "O" && Button09.Text == "O" && Button08.Text == "O"
            || Button01.Text == "O" && Button04.Text == "O" && Button07.Text == "O"
            || Button02.Text == "O" && Button05.Text == "O" && Button08.Text == "O"
            || Button03.Text == "O" && Button06.Text == "O" && Button09.Text == "O"
            || Button01.Text == "O" && Button05.Text == "O" && Button09.Text == "O"
            || Button03.Text == "O" && Button05.Text == "O" && Button07.Text == "O")
            {
                if (chosenShape == "O")
                {
                    PCTimer.Stop();
                    MessageCircle messageCircle = new MessageCircle(playerName);
                    messageCircle.ShowDialog();
                    playerWins++;
                    YouLabel.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                    YouLabel.Text = $"{playerName} : " + playerWins;

                    RestartGame();
                }
                else
                {
                    PCTimer.Stop();
                    MessageCircle messageCircle = new MessageCircle("PC");
                    messageCircle.ShowDialog();
                    computerWins++;
                    PCLabel.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                    PCLabel.Text = "PC : " + computerWins;
                    RestartGame();
                }
            }

            else if (allButtonsClicked)
            {
                Sounddoll1();
                StartNewGameMessage StartNewGameMessage = new StartNewGameMessage();
                StartNewGameMessage.ShowDialog();
                RestartGame();
                PlayBackgroundSound();
            }
        }



        private void RestartGame()
        {
            buttons = new List<Guna2Button> { Button01, Button02, Button03, Button04, Button05, Button06, Button07, Button08, Button09 };
            foreach (Guna2Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "";
                button.FillColor = Color.FromArgb(50, 50, 50);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
