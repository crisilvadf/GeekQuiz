using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    public class TriviaAnswer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserId { get; set; }

        public int OptionId { get; set; }

        public int QuestionId { get; set; }

        [JsonIgnore]
        public virtual TriviaOption TriviaOption { get; set; }
    }
}