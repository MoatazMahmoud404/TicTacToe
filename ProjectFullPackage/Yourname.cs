using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectFullPackage
{
    public partial class Yourname : Form
    {
        public string EnteredName { get; private set; }
        public Yourname()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            EnteredName = bigTextBox1.Text;
            this.Close();
        }
    }
}
