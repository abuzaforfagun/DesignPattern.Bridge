using PublisherOperations.Models;
using System;
using System.Collections.Generic;

namespace PublisherOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Need to execute all the printing task in a loop
            Book bookLiveLife = new Book()
            {
                Title = "How to live life",
                Author = "James",
                Description = "A book on life"
            };
            bookLiveLife.Print();

            QuestionBank questionBank = new QuestionBank()
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
            questionBank.Print();

            Book bookDesignPatters = new Book()
            {
                Title = "Design Patterns",
                Author = "GOF",
                Description = "23 design patterns"
            };
            bookDesignPatters.Print();
            Console.Read();
        }

    }
}