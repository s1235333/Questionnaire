namespace Questionnaire_ORM.OstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SurveyList")]
    public partial class SurveyList
    {
        [Key]
        public int Survey_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Condition { get; set; }

        [Required]
        [StringLength(100)]
        public string Contents { get; set; }

        public DateTime Stime { get; set; }

        public DateTime Etime { get; set; }

        [Required]
        [StringLength(50)]
        public string OnOff { get; set; }
    }
}
