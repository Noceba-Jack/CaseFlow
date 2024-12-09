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

namespace CaseFlowUI
{
    public partial class AddCase : Form
    {
        //declare case info object
        CCaseInfoContainer cCaseInfo = new CCaseInfoContainer();
        public AddCase()
        {
            InitializeComponent();
        }//constructor

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ensure that all fields are filled in before saving the information
            if (txtCaseNumber.Text != null || txtAccused.Text != null || txtCharge != null || txtIO != null || txtMASNumber != null || txtPostponementReason != null)
            {
                //initialise instances of the lists;
                cCaseInfo.isCompleted = new List<string>();
                cCaseInfo.caseNumber = new List<string>();
                cCaseInfo.MASNumber = new List<string>();
                cCaseInfo.accused = new List<string>();
                cCaseInfo.chargeType = new List<string>();
                cCaseInfo.investigatingOfficer = new List<string>();
                cCaseInfo.postponementReason = new List<string>();
                cCaseInfo.firstAppearanceDate = new List<string>();
                cCaseInfo.postponementDate = new List<string>();

                //collect case information from the form and allocate it to corresponding list
                cCaseInfo.caseNumber.Add(txtCaseNumber.Text);
                cCaseInfo.MASNumber.Add(txtMASNumber.Text);
                cCaseInfo.accused.Add(txtAccused.Text);
                cCaseInfo.chargeType.Add(txtCharge.Text);
                cCaseInfo.investigatingOfficer.Add(txtIO.Text);
                cCaseInfo.postponementReason.Add(txtPostponementReason.Text);
                cCaseInfo.firstAppearanceDate.Add(dtpFirstAppearnce.Value.ToShortDateString());
                cCaseInfo.postponementDate.Add(dtpPostponement.Value.ToShortDateString());

                //use serialisation to store the case information
                SerialiseToXML(cCaseInfo);

                //inform user that case was saved
                MessageBox.Show("Case added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //inform user that fields are empty
                MessageBox.Show("Empty Field(s)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear form
            txtPostponementReason.Clear();
            txtMASNumber.Clear();
            txtCharge.Clear();
            txtCaseNumber.Clear();
            txtAccused.Clear();
            dtpFirstAppearnce.Value = DateTime.Today;
            dtpPostponement.Value = DateTime.Today;
        }

        private void SerialiseToXML(CCaseInfoContainer _cCaseInfo)
        {
            
            FileStream fs = new FileStream(@"C:\C# files\CaseFlowUI\CaseFlowUI\CaseInformation.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(CCaseInfoContainer));
            serializer.Serialize(fs, _cCaseInfo);

            //close filestream
            fs.Close();
            fs.Dispose();
        }
    }
}
