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
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void btnRoman_Click(object sender, EventArgs e)
        {
            //Opens the Roman converter and closes current form
            Roman frmRoman = new Roman();
            this.Hide();
            frmRoman.Show();
        }

        private void btnArabic_Click(object sender, EventArgs e)
        {
            //Opens the Arabic converter and closes the current form
            Arabic_Converter frmArab = new Arabic_Converter();
            this.Hide();
            frmArab.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void programSpecificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens the help form
            Help frmHelp = new Help();
            frmHelp.Show();
        }

        private void msMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logs the user out, closes the current form and opens the Login form.
            Login frmLogin = new Login();
            this.Close();
            frmLogin.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Logs the user out, closes the current form and opens the Login form.
            Login frmLogin = new Login();
            this.Close();
            frmLogin.Show();
        }
    }
}
