using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class Form1 : Form
    {
        public string PlayerName { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayBttn_Click(object sender, EventArgs e)
        {
            if(inputName.Text.Length == 0)
            {
                nameRequiredError.Visible = true;
            }
            else {
                nameRequiredError.Visible = false;
            }
            this.Hide();
            Form2 game = new Form2();
            game.Show();
        }

        private void InputName_TextChanged(object sender, EventArgs e)
        {
            nameRequiredError.Visible = false;
        }
    }
}
