﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class TermPaper : PrintingItem
    {
        public string Title { get; set; }
        public string StudentId { get; set; }
        public string Refference { get; set; }
        public string Description { get; set; }


        public TermPaper(string title, string studentId, string refference, string description, IFormatter formatter)
            :base(formatter = null)
        {
            this.Title = title;
            this.StudentId = studentId;
            this.Refference = refference;
            this.Description = description;
        }
        public override void Print()
        {
            Console.WriteLine("Printing Term Paper...");
            Console.WriteLine(Formatter.Format("Title", Title));
            Console.WriteLine(Formatter.Format("Refference", Refference));
            Console.WriteLine(Formatter.Format("Description", Description));
            Console.WriteLine("-------------------------------");
        }   

    }
}
