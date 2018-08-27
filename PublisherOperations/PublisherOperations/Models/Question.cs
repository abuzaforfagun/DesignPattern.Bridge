using PublisherOperations.Interface;

namespace PublisherOperations.Models
{
    public class Question : IPrintingItem, IQuestion
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }

        public Question(int questionId, string questionText, string answer)
        {
            this.QuestionId = questionId;
            this.QuestionText = questionText;
            this.Answer = answer;
        }
        public void Print()
        {
            System.Console.WriteLine($"Q No: ${QuestionId}");
            System.Console.WriteLine($"Q: ${QuestionText}");
            System.Console.WriteLine($"A: ${Answer}");
        }
    }
}