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
                
                string a;
                string b;
                
                
                
                string converted;
                converted = ArabicToNumeral.ArabicToRoman(int.Parse(arabicNumeralTB.Text));

                //My variables a, b, and c to indicate objects I do not want within code.
                a = "(";
                b = ")";
                
                
            

                label3.Text = converted.ToString();
                arabicNumeralTB.Focus();
                if (label3.Text.Contains(a) == true && label3.Text.Contains(b) == true)
                {
                    lblInvalid.Text = "Please enter a number less than 4000!";
                    lblInvalid.Visible = true;
                    lblInvalid.ForeColor = Color.Red;
                    lblOne.ForeColor = Color.Red;
                    labelThree.ForeColor = Color.Red;


                }
                else if ((arabicNumeralTB.Text.Contains(a) == false && arabicNumeralTB.Text.Contains(b) == false))

                {
                    lblInvalid.Text = "Successful";
                    lblInvalid.ForeColor = Color.Green;
                    lblInvalid.Visible = true;
                    lblOne.ForeColor = Color.Green;
                    labelThree.ForeColor = Color.Green;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void romanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roman frmArb = new Roman();
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

            try
            {
                Application.Exit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                arabicNumeralTB.Text = "";
                label3.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Help frmHelp = new Help();
                frmHelp.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {try
            {
                Login frmLogin = new Login();
                this.Close();
                frmLogin.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
