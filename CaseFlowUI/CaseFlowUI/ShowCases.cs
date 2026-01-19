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

            string sql = "Select * from accused";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            connection.Open();
            dataAdapter.Fill(dataSet);
            connection.Close();

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
