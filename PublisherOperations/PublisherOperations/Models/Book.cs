﻿using PublisherOperations.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class Book : IPrintingItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public void Print()
        {
            Console.WriteLine("Printing Book...");
            Console.WriteLine($"Title: ${Title}");
            Console.WriteLine($"Author: ${Author}");
            Console.WriteLine($"Description: ${Description}");
            Console.WriteLine("-------------------------------");
        }
    }
}
