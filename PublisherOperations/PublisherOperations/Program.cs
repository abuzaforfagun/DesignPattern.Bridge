using PublisherOperations.Interface;
using PublisherOperations.Models;
using System;
using System.Collections.Generic;

namespace PublisherOperations
{
    class Program
    {

        //TODO: #P2, add string formating mechanism while printing
        static void Main(string[] args)
        {
            IList<IPrintingItem> printingItemQueue = new List<IPrintingItem>();
            var bookLiveLife = new BookFancyFormat("How to live life", "Jhon", "A book on life");
            printingItemQueue.Add(bookLiveLife);
            IPrintingItem questionBank = GenerateQuestionBank();

            printingItemQueue.Add(questionBank);
            var bookDesignPatters = new BookFancyFormat("Design Patterns", "GOF", "23 Design Patterns");

            printingItemQueue.Add(bookDesignPatters);
            PrintCollection(printingItemQueue);
            Console.Read();
        }

        private static void PrintCollection(IList<IPrintingItem> printingItemQueue)
        {
            foreach (var item in printingItemQueue)
            {
                item.Print();
            }
        }

        private static IPrintingItem GenerateQuestionBank()
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