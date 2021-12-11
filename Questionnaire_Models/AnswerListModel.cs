using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Models
{
    public class AnswerListModel
    {
        public Guid AID { get; set; }
        public Guid Result_ID { get; set; }
        public Guid Question_ID { get; set; }
        public string Answer { get; set; }

    }
}
