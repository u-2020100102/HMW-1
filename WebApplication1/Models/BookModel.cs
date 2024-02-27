using System;

namespace WebApplication1.Models
{
    public class BookModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public DateTime DueDate { get; set; }

        public int DaysUntilDue => (DueDate - DateTime.Now).Days;
    }
}