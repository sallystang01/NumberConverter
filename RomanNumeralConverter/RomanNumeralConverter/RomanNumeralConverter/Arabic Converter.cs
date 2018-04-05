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
                //Varaibles 
                string a;
                string b;
                
                
                
                string converted;
                //Takes the result of the method and puts it into the variable
                converted = ArabicToNumeral.ArabicToRoman(int.Parse(arabicNumeralTB.Text));

                //My variables a, b, and c to indicate objects I do not want within code.
                a = "(";
                b = ")";
                
                
            
                //Text of label 3 is the variable to string
                label3.Text = converted.ToString();
                //Brings the focus back to the text box
                arabicNumeralTB.Focus();
                //If the result in the output label contains parenthesis, then do the following
                if (label3.Text.Contains(a) == true && label3.Text.Contains(b) == true)
                {
                    //Changes properties of the following:
                    lblInvalid.Text = "Please enter a number less than 4000!";
                    lblInvalid.Visible = true;
                    lblInvalid.ForeColor = Color.Red;
                    lblOne.ForeColor = Color.Red;
                    labelThree.ForeColor = Color.Red;


                }
                //If no parenthesis are found, then do the following
                else if ((arabicNumeralTB.Text.Contains(a) == false && arabicNumeralTB.Text.Contains(b) == false))

                {
                    //Changes properties of the following:
                    lblInvalid.Text = "Successful";
                    lblInvalid.ForeColor = Color.Green;
                    lblInvalid.Visible = true;
                    lblOne.ForeColor = Color.Green;
                    labelThree.ForeColor = Color.Green;

                }
            }

            catch (Exception ex)
            {
                //Catches exception if error occurs after clicking button
                MessageBox.Show(ex.Message);
            }
        }

        private void romanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes current form and opens Form1
            Roman frmArb = new Roman();
            this.Close();
            frmArb.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes current form and open Default form
            Default frmDefault = new Default();
            this.Close();
            frmDefault.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            try
            {
                //Exits program
                Application.Exit();
            }

            catch (Exception ex)
            {
                //Catches any exceptions that may occur (Precaution)
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Clears text of the following:
                arabicNumeralTB.Text = "";
                label3.Text = "";
            }

            catch (Exception ex)
            {
                //Precaution
                MessageBox.Show(ex.Message);
            }
        }

        private void getHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //Shows the help form
                Help frmHelp = new Help();
                frmHelp.Show();
            }

            catch (Exception ex)
            {
                //Precaution
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {try
            {
                //Opens the login form and closes current form
                Login frmLogin = new Login();
                this.Close();
                frmLogin.Show();
            }

            catch (Exception ex)
            {
                //Exception/Precaution
                MessageBox.Show(ex.Message);
            }
        }
    }
}
