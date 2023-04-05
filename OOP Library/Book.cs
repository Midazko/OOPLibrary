using OOPlibrary;
using System.Reflection;

namespace OOPlibrary
{
    public class Book
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public int Borrowed { get; set; }


        public Book(string title, int count)
        {
            Title = title;
            Count = count;
            Borrowed = 0;
        }

    }

}