using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class QuestionBank : PrintingItem
    {
        public QuestionBank(IFormatter formatter = null):
            base(formatter)
        {

        }
        public string Subject { get; set; }
        public IEnumerable<IQuestion> Questions { get; set; }
        public override void Print()
        {
            Console.WriteLine("Printing Question Bank...");
            Console.WriteLine($"Subject: {Subject}");
            foreach (var item in Questions)
            {
                item.Print();
            }
            Console.WriteLine("------------------------");
        }
    }
}
