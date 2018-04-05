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
                //Converts the roman numeral to an Arabic number
                int converted;
                converted = NumberConverter.RomanToInteger(romanNumeralTB.Text.ToUpper());
                //Displays the converted text inside the label
                outputLB.Text = converted.ToString();
                //Brings the focus back to the text box for easy access. User can
                //Immediately input another Roman Numeral
                romanNumeralTB.Focus();
            }
            
            catch (Exception ex)
            {
                //Catches an exception if something goes wrong when the button is clicked.
                MessageBox.Show(ex.Message);
            }
            



            
        }

       


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the form
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void arabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the current form and opens the Arabic converter
            Arabic_Converter frmArabic = new Arabic_Converter();
            this.Close();
            frmArabic.Show();
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the current form and opens the Default form
            Default frmDefault = new Default();
            this.Close();
            frmDefault.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clears all text fields of the text box and output label
            romanNumeralTB.Text = "";
            outputLB.Text = "";
        }

        private void getHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shows the help form
            Help frmHelp = new Help();
            frmHelp.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes current form and opens the login page.
            Login frmLogin = new Login();
            this.Close();
            frmLogin.Show();
        }
    }
}
