using PublisherOperations.Models;
using System;
using System.Collections.Generic;

namespace PublisherOperations
{
    class Program
    {

        static void Main(string[] args)
        {
            IList<PrintingItem> printingItemQueue = new List<PrintingItem>();
            var bookLiveLife = new Book("How to live life", "Jhon", "A book on life");
            printingItemQueue.Add(bookLiveLife);
            PrintingItem questionBank = GenerateQuestionBank();

            printingItemQueue.Add(questionBank);
            var bookDesignPatters = new Book("Design Patterns", "GOF", "23 Design Patterns", new UppercaseFormatter());

            printingItemQueue.Add(bookDesignPatters);
            var bookProgrammingWithCSharp = new Book("Programming With C#", "Unknown", "Programming With C#");
            printingItemQueue.Add(bookProgrammingWithCSharp);

            PrintCollection(printingItemQueue);
            Console.Read();
        }

        private static void PrintCollection(IList<PrintingItem> printingItemQueue)
        {
            foreach (var item in printingItemQueue)
            {
                item.Print();
            }
        }

        private static PrintingItem GenerateQuestionBank()
        {
            return new QuestionBank()
            {
                Subject = "C#",
                Questions = new List<Question>()
                {
                    new Question(1, "Current version of C#?", "7"),
                    new Question(2, "Can we pass mutliple?", "Yes, we can pass though tuple.")
                }
            };
        }
        
    }
}