using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormVSC2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = LoginInput.Text;
            string pass = PassInput.Text;
            bool checker = FreakBox.Checked;
            LoginInput.Text = "";
            PassInput.Text = "";
            FreakBox.Checked = false;

            if (string.IsNullOrEmpty(user))
            { label1.Text = "⚠ bro tryna access a no name 💀"; }
            else if (checker != true)
            { label1.Text = "⚠ vital form parts missing"; }
            else if (pass != "admin" || user != "admin")
            { label1.Text = "⚠ wrong password or username"; }
            else { label1.Text = "i mean you kinda entered"; }
        }

        private void LoginInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
