using GeekQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace GeekQuiz.Data.EntityConfig
{
    public class TriviaAnswerConfig : EntityTypeConfiguration<TriviaAnswer>
    {
        public TriviaAnswerConfig()
        {
            ToTable("TriviaAnswer");
            HasKey(a => a.Id);
        }
    }
}