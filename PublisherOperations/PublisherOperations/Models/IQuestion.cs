namespace PublisherOperations.Models
{
    public interface IQuestion
    {
        string Answer { get; set; }
        int QuestionId { get; set; }
        string QuestionText { get; set; }

        void Print();
    }
}