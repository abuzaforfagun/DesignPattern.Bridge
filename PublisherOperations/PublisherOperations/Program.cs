using PublisherOperations.Interface;
using PublisherOperations.Models;
using System;
using System.Collections.Generic;

namespace PublisherOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IPrintingItem> printingItemQueue = new List<IPrintingItem>();
            var bookLiveLife = GenerateBookLiveLife();
            printingItemQueue.Add(bookLiveLife);
            IPrintingItem questionBank = GenerateQuestionBank();

            printingItemQueue.Add(questionBank);
            var bookDesignPatters = GenerateBookDesignPattern();

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

        private static IPrintingItem GenerateBookDesignPattern()
        {
            return new Book()
            {
                Title = "Design Patterns",
                Author = "GOF",
                Description = "23 design patterns"
            };
        }

        private static IPrintingItem GenerateQuestionBank()
        {
            return new QuestionBank()
            {
                Subject = "C#",
                Questions = new List<Question>()
                {
                    new Question()
                    {
                        QuestionId = 1,
                        QuestionText = "Current version of C#?",
                        Answer = "7"
                    },
                    new Question()
                    {
                        QuestionId = 2,
                        QuestionText = "Can we pass mutliple ",
                        Answer = "Yes, we can pass though tuple."
                    }
                }
            };
        }

        private static IPrintingItem GenerateBookLiveLife()
        {
            return new Book()
            {
                Title = "How to live life",
                Author = "James",
                Description = "A book on life"
            };
        }
    }
}