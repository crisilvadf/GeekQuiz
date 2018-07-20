using GeekQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace GeekQuiz.Data.EntityConfig
{
    public class TriviaOptionConfig : EntityTypeConfiguration<TriviaOption>
    {
        public TriviaOptionConfig()
        {
            ToTable("TriviaOption");
            HasKey(a => a.Id);
        }
    }
}