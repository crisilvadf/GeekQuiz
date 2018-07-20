using GeekQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace GeekQuiz.Data.EntityConfig
{
    public class TriviaQuestionConfig : EntityTypeConfiguration<TriviaQuestion>
    {
        public TriviaQuestionConfig()
        {
            ToTable("TriviaQuestion");
            HasKey(a => a.Id);
        }
    }
}