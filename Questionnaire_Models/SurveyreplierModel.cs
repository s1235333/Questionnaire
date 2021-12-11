using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Models
{
    public class SurveyreplierModel
    {
        public Guid Result_ID { get; set; }
        public int survey_ID { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
        public DateTime InputTime { get; set; }
    }
}
