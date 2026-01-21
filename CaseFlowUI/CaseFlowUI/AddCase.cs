using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;

namespace CaseFlowUI
{
    public partial class AddCase : Form
    {
        //declare case info object
        //CCaseInfoContainer cCaseInfo = new CCaseInfoContainer();
        public AddCase()
        {
            InitializeComponent();
        }//constructor

        //test value to see if date was selected
        Nullable<DateTime> selectedDate = null;//DateTime is not nullable by default
        private void dtpFirstAppearnce_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dtpFirstAppearnce.Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //connection string
                string connectionString = @"Data Source=LAPTOP-G9D69D5J\MSSQLSERVER01;Initial Catalog=CaseFlow;Integrated Security=True";

                //establish the connection
                SqlConnection connection = new SqlConnection(connectionString);

                //create the command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                

                //ensure that all fields are filled in before saving the information
                if (!string.IsNullOrWhiteSpace(txtCaseNumber.Text) && !string.IsNullOrWhiteSpace(txtAccName.Text) && !string.IsNullOrWhiteSpace(txtAccSurname.Text) && !string.IsNullOrWhiteSpace(txtCharge.Text) && !string.IsNullOrWhiteSpace(txtIO.Text) && !string.IsNullOrWhiteSpace(txtMASNumber.Text) && selectedDate.HasValue)
                {
                    //convert case number and mas number into int
                    if (int.TryParse(txtCaseNumber.Text, out int iCaseNumber) && int.TryParse(txtMASNumber.Text, out int iMASNumber))
                    {
                        //add case info to the stored procedure for postponed case
                        if ((chbCasePostponed.Checked == true) && (dtpPostponement.Checked == true) && (txtPostponementReason != null))
                        {
                            //stored procedure for postponed case
                            //command.CommandText = "AddCase";
                            //command.CommandType = CommandType.StoredProcedure;

                            //add parameters to stored procedure
                            command.Parameters.AddWithValue("@CaseNumber", iCaseNumber);
                            command.Parameters.AddWithValue("@MASNumber", iMASNumber);
                            command.Parameters.AddWithValue("@accusedName", txtAccName.Text);
                            command.Parameters.AddWithValue("@accusedSurname", txtAccSurname.Text);
                            command.Parameters.AddWithValue("@investigatingOfficerSurname", txtIO.Text);
                            command.Parameters.AddWithValue("@firstAppearanceDate", dtpFirstAppearnce.Value);
                            command.Parameters.AddWithValue("@accusedCharge", txtCharge.Text);
                            command.Parameters.AddWithValue("@postponementReason", txtPostponementReason.Text);
                            command.Parameters.AddWithValue("@postponementDate", dtpPostponement.Value);
                        }
                        else
                        {
                            //stored procedure for normal case
                            command.CommandText = "AddCase";
                            command.CommandType = CommandType.StoredProcedure;

                            //add parameters to stored procedure
                            command.Parameters.AddWithValue("@CaseNumber", iCaseNumber);
                            command.Parameters.AddWithValue("@MASNumber", iMASNumber);
                            command.Parameters.AddWithValue("@accusedName", txtAccName.Text);
                            command.Parameters.AddWithValue("@accusedSurname", txtAccSurname.Text);
                            command.Parameters.AddWithValue("@investigatingOfficerSurname", txtIO.Text);
                            command.Parameters.AddWithValue("@firstAppearanceDate", dtpFirstAppearnce.Value);
                            command.Parameters.AddWithValue("@accusedCharge", txtCharge.Text);
                        }

                    }
                    else
                    {
                        //inform user invalid case and mas number
                        MessageBox.Show("Invalid Case Number and/or MAS Number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    //execute command
                    connection.Open();
                    int iRowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (iRowsAffected > 0)
                    {
                        //inform user that case was saved
                        MessageBox.Show("Case added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //inform user that case was not saved
                        MessageBox.Show("Case not saved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                else
                {
                    //inform user that fields are empty
                    MessageBox.Show("Empty Field(s) or Date Not Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                //inform user that there is an error somewhere
                MessageBox.Show(error.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear form
            txtPostponementReason.Clear();
            txtMASNumber.Clear();
            txtCharge.Clear();
            txtCaseNumber.Clear();
            txtAccName.Clear();
            dtpFirstAppearnce.Value = DateTime.Today;
            dtpPostponement.Value = DateTime.Today;
        }

        
    }
}
