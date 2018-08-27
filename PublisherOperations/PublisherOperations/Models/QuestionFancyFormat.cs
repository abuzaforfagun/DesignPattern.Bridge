using PublisherOperations.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class QuestionFancyFormat:IPrintingItem, IQuestion
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }

        public QuestionFancyFormat(int questionId, string questionText, string answer)
        {
            this.QuestionId = questionId;
            this.QuestionText = questionText;
            this.Answer = answer;
        }
        public void Print()
        {
            System.Console.WriteLine($"Question No: #{QuestionId}");
            System.Console.WriteLine($"\tQ: {QuestionText}");
            System.Console.WriteLine($"\tA: {Answer}");
        }
    }
}
