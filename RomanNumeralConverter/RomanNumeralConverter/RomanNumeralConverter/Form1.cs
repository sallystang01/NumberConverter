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
    public partial class Roman : Form
    {
        public Roman()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            NumberConverter romanConverter = new NumberConverter();

            
            
            

            try
            {
                int converted;
                converted = NumberConverter.RomanToInteger(romanNumeralTB.Text.ToUpper());

                outputLB.Text = converted.ToString();
                romanNumeralTB.Focus();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



            
        }

       


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void arabicToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Arabic_Converter frmArabic = new Arabic_Converter();
            this.Close();
            frmArabic.Show();
            
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
            romanNumeralTB.Text = "";
            outputLB.Text = "";
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
