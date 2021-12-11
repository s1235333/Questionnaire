using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Models
{
    public class SurveyListModel
    {
        public int Survey_ID { get; set; }
        public string Title { get; set; }
        public string Condition { get; set; }
        public string Contents { get; set; }
        public DateTime Stime { get; set; }
        public DateTime Etime { get; set; }
        public string OnOff { get; set; }
    }
}
