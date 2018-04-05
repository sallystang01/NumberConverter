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
                //Establishes the connection to the database

                //connString is just the connection string
                 string connString = "Server=DTPLAPTOP12;Database=Numeric;Trusted_Connection=True;";

                //New connection using connString
                 SqlConnection sqlAccounts = new SqlConnection(connString);
                
                
                //Creates a SqlCommand class
                using (SqlCommand cmdAccounts = new SqlCommand("spUserAccount", sqlAccounts))
                {
                    //Command type is a stored procedure
                    cmdAccounts.CommandType = CommandType.StoredProcedure;
                    //Supplies the parameters within your stored procedure (tbUser.Text will supply the parameter @user)
                    cmdAccounts.Parameters.AddWithValue("@user", tbUser.Text);
                    cmdAccounts.Parameters.AddWithValue("@pass", tbPass.Text);

                    //Opens the connection to the database
                    sqlAccounts.Open();
                    //This is used because we aren't trying to return a value
                    cmdAccounts.ExecuteNonQuery();
                    
                    //Adapter allows for select/insert statements (I think)
                    SqlDataAdapter daAccounts = new SqlDataAdapter();

                    //Creates virtual table for the entity returned from the stored procedure (I think that's what's going on here)
                    DataTable dtAccounts = new DataTable();

                    //Basically selects the record in the database
                    daAccounts.SelectCommand = cmdAccounts;

                    //Puts that record in your data table
                    daAccounts.Fill(dtAccounts);

                    //Closes the connection.
                    sqlAccounts.Close();


                    //Variables
                    int count;
                   
                    //Counts the rows in data table.
                    count = dtAccounts.Rows.Count;
                  

                    //If the row return = 1, close the login form and open the converter.
                    if (count == 1)
                    {
                        Default frmDefault = new Default();
                        this.Hide();
                        frmDefault.Show();
                        

                    }
                    // Else, display error.
                    else
                    {
                        lblError.Visible = true;
                    }

                }    





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

       

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            CreateAccount frmCA = new CreateAccount();
            this.Hide();
            frmCA.Show();
        }
    }
}
