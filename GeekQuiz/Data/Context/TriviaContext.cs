using GeekQuiz.Data.EntityConfig;
using GeekQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeekQuiz.Data.Context
{
    public class TriviaContext : DbContext
    {

        public TriviaContext()
            : base("TriviaContextEntities")
        {
            Database.SetInitializer<TriviaContext>(null);
        }

        public DbSet<TriviaQuestion> TriviaQuestions { get; set; }
        public DbSet<TriviaOption> TriviaOptions { get; set; }
        public DbSet<TriviaAnswer> TriviaAnswers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Configurations.Add(new TriviaAnswerConfig());
            modelbuilder.Configurations.Add(new TriviaOptionConfig());
            modelbuilder.Configurations.Add(new TriviaQuestionConfig());
        }
    }
}