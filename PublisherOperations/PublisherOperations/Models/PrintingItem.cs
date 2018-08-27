namespace PublisherOperations.Models
{
    public abstract class PrintingItem
    {
        public IFormatter Formatter { get; set; }
        public PrintingItem(IFormatter formatter = null)
        {
            Formatter = formatter ?? new BasicFormatter();
        }
        public abstract void Print();
    }
}