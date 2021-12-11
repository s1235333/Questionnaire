namespace Questionnaire_ORM.OstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnswerList")]
    public partial class AnswerList
    {
        [Key]
        [Column(Order = 0)]
        public Guid AID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Result_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid Question_ID { get; set; }

        [StringLength(100)]
        public string Answer { get; set; }
    }
}
