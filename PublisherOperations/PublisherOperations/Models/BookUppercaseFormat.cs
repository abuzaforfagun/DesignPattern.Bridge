using PublisherOperations.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    class BookUppercaseFormat : IPrintingItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public BookUppercaseFormat(string title, string author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
        }

        public void Print()
        {
            Console.WriteLine("Printing Book...");
            Console.WriteLine($"\tTitle: ${Title.ToUpper()}");
            Console.WriteLine($"\tAuthor: ${Author.ToUpper()}");
            Console.WriteLine($"\tDescription: ${Description.ToUpper()}");
            Console.WriteLine("-------------------------------");
        }
    }
}
