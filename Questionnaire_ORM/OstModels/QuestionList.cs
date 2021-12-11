namespace Questionnaire_ORM.OstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionList")]
    public partial class QuestionList
    {
        [Key]
        [Column(Order = 0)]
        public Guid Question_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Survey_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public int QuestionSort { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Question { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(150)]
        public string Options { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Must { get; set; }
    }
}
