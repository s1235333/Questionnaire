using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Questionnaire_ORM.OstModels
{
    public partial class OstContextModel : DbContext
    {
        public OstContextModel()
            : base("name=OstContextModel")
        {
        }

        public virtual DbSet<SurveyList> SurveyLists { get; set; }
        public virtual DbSet<Surveyreplier> Surveyrepliers { get; set; }
        public virtual DbSet<AnswerList> AnswerLists { get; set; }
        public virtual DbSet<QuestionList> QuestionLists { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
