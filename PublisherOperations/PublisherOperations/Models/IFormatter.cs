namespace PublisherOperations.Models
{
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}