namespace Questionnaire_ORM.OstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Surveyreplier")]
    public partial class Surveyreplier
    {
        [Key]
        public Guid Result_ID { get; set; }

        public int Survey_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Tel { get; set; }

        [Required]
        [StringLength(50)]
        public string Mail { get; set; }

        public int Age { get; set; }

        public DateTime InputTime { get; set; }
    }
}
