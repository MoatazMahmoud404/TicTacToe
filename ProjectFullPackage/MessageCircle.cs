using System.Windows.Forms;
using System;

namespace ProjectFullPackage
{
    public partial class MessageCircle : Form
    {
        public MessageCircle(string playerName) 
        {
            InitializeComponent();
            label1.Text = $"Winner is {playerName}";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
