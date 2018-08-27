using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class Book : PrintingItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public Book(string title, string author, string description)
        {
            this.Title = title;
            this.Author = author;
            this.Description = description;
        }
        public override void Print()
        {
            Console.WriteLine("Printing Book...");
            Console.WriteLine($"Title: ${Title}");
            Console.WriteLine($"Author: ${Author}");
            Console.WriteLine($"Description: ${Description}");
            Console.WriteLine("-------------------------------");
        }
    }
}
