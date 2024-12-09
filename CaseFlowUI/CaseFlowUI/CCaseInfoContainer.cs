using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseFlowUI
{
    public class CCaseInfoContainer
    {
        //private data fields
        //private List<int> iCaseNumber;
        //private List<int> iMASNumber;
        //private List<DateTime> iFirstAppearanceDate;
        //private List<DateTime> iPostponementDate;
        //private List<DateTime> iOlderThan6Months;

        //auto-implemented properties
        public List<string> investigatingOfficer { get; set; }
        public List<string> chargeType { get; set; }
        public List<string> postponementReason { get; set; }
        public List<string> accused { get; set; }
        public List<string> isCompleted { get; set; }
        public List<string> caseNumber { get; set; }
        public List<string> MASNumber { get; set; }
        public List<string> firstAppearanceDate { get; set; }
        public List<string> postponementDate { get; set; }
        public List<string> olderThan6months { get; set; }

        //public Dictionary<string, List<string>> caseInfoDictionary { get; set; }
    }
}
