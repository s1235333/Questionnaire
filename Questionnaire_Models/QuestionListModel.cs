using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Models
{
    public class QuestionListModel
    {
        public Guid Question_ID { get; set; }
        public int TypeID { get; set; }
        public int Survey_ID { get; set; }
        public int QuestionSort { get; set; }
        public string Question { get; set; }
        public string Options { get; set; }
        public int Must { get; set; }
    }
}
