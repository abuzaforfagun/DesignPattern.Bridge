using PublisherOperations.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class BookFancyFormat : IPrintingItem
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public BookFancyFormat(string title, string author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
        }

        public void Print()
        {
            Console.WriteLine("Printing Book...");
            Console.WriteLine($"\tTitle: ${Title}");
            Console.WriteLine($"\tAuthor: ${Author}");
            Console.WriteLine($"\tDescription: ${Description}");
            Console.WriteLine("-------------------------------");
        }
    }
}
