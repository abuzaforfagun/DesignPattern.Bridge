using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class TermPaper
    {
        public string Title { get; set; }
        public string StudentId { get; set; }
        public string Refference { get; set; }
        public string Description { get; set; }

        public void Print()
        {
            Console.WriteLine("Printing Term Paper...");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Refference: {Refference}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine("-------------------------------");

        }   

    }
}
