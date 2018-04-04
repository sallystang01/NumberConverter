using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralConverter
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string username;
                string password;

                username = "Hunter";
                password = "1234";

                lblUser.Focus();
                if (tbUser.Text == username && tbPass.Text == password)
                {
                    Default frmDefault = new Default();
                    this.Hide();
                    frmDefault.Show();

                }
                else
                {
                    MessageBox.Show("Please enter in a valid username or password");
                }
                tbUser.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemember.Checked == true)
            {
                tbUser.Text = "Hunter";
                tbPass.Text = "1234";
            }
        }
    }
}
