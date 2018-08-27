namespace PublisherOperations.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"Q No: ${QuestionId}");
            System.Console.WriteLine($"Q: ${QuestionText}");
            System.Console.WriteLine($"A: ${Answer}");
        }
    }
}