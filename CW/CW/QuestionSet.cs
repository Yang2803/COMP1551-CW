using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    public class QuestionSet
    {
        public string SetName { get; set; }
        public List<BaseQuestion> Questions { get; set; } = new List<BaseQuestion>();
    }
}
