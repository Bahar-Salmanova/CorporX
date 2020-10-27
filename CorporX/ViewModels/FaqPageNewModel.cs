using CorporX.Models;
using CorporX.Models.Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class FaqPageNewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<AnswerQuestions> AnswerQuestions { get; set; }
        public List<AskedQuestions> AskedQuestions { get; set; }


    }
}
