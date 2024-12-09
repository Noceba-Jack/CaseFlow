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

namespace CaseFlowUI
{
    public partial class ShowCases : Form
    {
        public ShowCases()
        {
            InitializeComponent();
        }//constructor

        //load table when the form loads
        private void ShowCases_Load(object sender, EventArgs e)
        {
            //load the datagridview
            //declare the dictionary to be used for deserialisation
            CCaseInfoContainer cCaseInfo = XmlDeserialiser();

            //store data in the object dictionary
            Dictionary<string, List<string>> caseDictionary = new Dictionary<string, List<string>>()
                {
                    {"Case Number", cCaseInfo.caseNumber},
                    {"MAS Number", cCaseInfo.MASNumber },
                    {"Accused", cCaseInfo.accused },
                    {"Charge Type", cCaseInfo.chargeType },
                    {"Investigating Officer", cCaseInfo.investigatingOfficer },
                    {"Postponement Reason", cCaseInfo.postponementReason },
                    {"First Appearance", cCaseInfo.firstAppearanceDate },
                    {"Postponed To", cCaseInfo.postponementDate }
                };

            //assign the dictionary to a datatable
            DataTable dataTable = new DataTable();

            foreach (var key in caseDictionary.Keys)
            {
                dataTable.Columns.Add(key, typeof(string));
            }//assign the colums

            int rowCount = caseDictionary["Case Number"].Count;
            for (int i = 0; i < rowCount; i++)
            {
                DataRow row = dataTable.NewRow();

                foreach (var key in caseDictionary.Keys)
                {
                    row[key] = caseDictionary[key][i];
                }

                dataTable.Rows.Add(row);
            }//assign the rows

            //bind data table to the datagridview
            dgvCaseInformation.AutoResizeColumns();
            dgvCaseInformation.DataSource = dataTable;
        }

        public CCaseInfoContainer XmlDeserialiser()
        {
            FileStream fs = new FileStream(@"C:\C# files\CaseFlowUI\CaseFlowUI\CaseInformation.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(CCaseInfoContainer));
            CCaseInfoContainer _cCaseInfo = (CCaseInfoContainer)serializer.Deserialize(fs);

            //close the file stream
            fs.Close();

            return _cCaseInfo;
        }
    }
}
