using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class QuestionBank
    {
        public string Subject { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
