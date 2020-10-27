using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models
{
    public class AnswerQuestions
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Answer { get; set; }
        [MaxLength(500)]
        public string Questions { get; set; }
    }
}
