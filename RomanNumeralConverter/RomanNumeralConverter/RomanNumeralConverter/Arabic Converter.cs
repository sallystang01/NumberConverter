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
    public partial class Arabic_Converter : Form
    {
        public Arabic_Converter()
        {
            InitializeComponent();
        }

        private void calculate2BTN_Click(object sender, EventArgs e)
        {
            try
            {
                string converted;
                converted = ArabicToNumeral.ArabicToRoman(int.Parse(arabicNumeralTB.Text));

                label3.Text = converted.ToString();
                arabicNumeralTB.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void romanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmArb = new Form1();
            this.Close();
            frmArb.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Default frmDefault = new Default();
            this.Close();
            frmDefault.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arabicNumeralTB.Text = "";
            label3.Text = "";
        }

        private void getHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help frmHelp = new Help();
            frmHelp.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Close();
            frmLogin.Show();
        }
    }
}
