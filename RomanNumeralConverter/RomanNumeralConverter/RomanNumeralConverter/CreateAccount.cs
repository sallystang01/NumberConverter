using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RomanNumeralConverter
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {

                //Establishes the connection to the database

                //connString is just the connection string
                string connString = "Server=DTPLAPTOP12;Database=Numeric;Trusted_Connection=True;";
                //New connection using connString
                SqlConnection sqlAccounts = new SqlConnection(connString);


                //Creates a SqlCommand class
                using (SqlCommand cmdAccounts = new SqlCommand("spNewUser", sqlAccounts))
                {
                    //Command type is a stored procedure
                    cmdAccounts.CommandType = CommandType.StoredProcedure;
                    //Supplies the parameters within your stored procedure (tbUser.Text will supply the parameter @user)

                    cmdAccounts.Parameters.AddWithValue("@firstName", tbFirstName.Text);
                    cmdAccounts.Parameters.AddWithValue("@lastName", tbLastName.Text);
                    cmdAccounts.Parameters.AddWithValue("@user", tbUser.Text);
                    cmdAccounts.Parameters.AddWithValue("@pass", tbPass.Text);
                    //Opens connection
                    sqlAccounts.Open();
                    //Not returning a value
                    cmdAccounts.ExecuteNonQuery();
                    //New adapter
                    SqlDataAdapter daAccounts = new SqlDataAdapter();
                    //New data table
                    DataTable dtAccounts = new DataTable();
                    //Inserts records from above in the cmdAccounts.Parameters.AddWithValue statements
                    daAccounts.InsertCommand = cmdAccounts;
                    //closes connection
                    sqlAccounts.Close();

                    
                    //Changes form size, displays labels and turns the text boxes to read only
                    this.Size = new Size(300, 355) ;
                    btnCreateAcc.Visible = false;
                    lblSuccess.Visible = true;
                    btnLogin.Visible = true;
                    tbFirstName.Text = "";
                    tbLastName.Text = "";
                    tbUser.Text = "";
                    tbPass.Text = "";

                    tbFirstName.ReadOnly = true;
                    tbLastName.ReadOnly = true;
                    tbUser.ReadOnly = true;
                    tbPass.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Closes this form and returns to login form
            Login frmLog = new Login();
            this.Close();
            frmLog.Show();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            //Shows and hides the password depending if the box is checked
            if (cbShowPass.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }

        }
    }
    }
