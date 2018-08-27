using PublisherOperations.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class QuestionBank : IPrintingItem
    {
        public string Subject { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public void Print()
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
