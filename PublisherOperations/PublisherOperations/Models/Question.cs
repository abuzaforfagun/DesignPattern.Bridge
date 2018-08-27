
namespace PublisherOperations.Models
{
    public class Question : PrintingItem, IQuestion
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }

        public Question(int questionId, string questionText, string answer, IFormatter formatter = null)
            :base(formatter)
        {
            this.QuestionId = questionId;
            this.QuestionText = questionText;
            this.Answer = answer;
        }
        public override void Print()
        {
            System.Console.WriteLine(Formatter.Format("Q No", QuestionId.ToString()));
            System.Console.WriteLine(Formatter.Format("Q", QuestionText));
            System.Console.WriteLine(Formatter.Format("A", Answer));
        }
    }
}