using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;

namespace CaseFlowUI
{
    public partial class ShowCases : Form
    {
        public ShowCases()
        {
            InitializeComponent();
        }//constructor

        private void btnLoadCases_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G9D69D5J\MSSQLSERVER01;Initial Catalog=CaseFlow;Integrated Security=True");*/
        }

        //load table when the form loads
        private void ShowCases_Load(object sender, EventArgs e)
        {
            //connection string
            string connectionString = @"Data Source=LAPTOP-G9D69D5J\MSSQLSERVER01;Initial Catalog=CaseFlow;Integrated Security=True";

            //establish the connection
            SqlConnection connection = new SqlConnection(connectionString);

            //create the command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DisplayCases";
            command.CommandType = CommandType.StoredProcedure;

            //execute command
            connection.Open();
            //using data adapter because user needs to navigate the data and also data needs to be plugged into a datagridview
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            connection.Close();

            //input data to datagridview
            dgvCaseInformation.DataSource = dataSet.Tables[0];
        }

        /*public CCaseInfoContainer XmlDeserialiser()
        {
            FileStream fs = new FileStream(@"C:\C# files\CaseFlowUI\CaseFlowUI\CaseInformation.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(CCaseInfoContainer));
            CCaseInfoContainer _cCaseInfo = (CCaseInfoContainer)serializer.Deserialize(fs);

            //close the file stream
            fs.Close();

            return _cCaseInfo;
        }*/

        
    }
}
