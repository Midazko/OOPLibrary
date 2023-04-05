using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPlibrary;
using static System.Reflection.Metadata.BlobBuilder;

namespace OOPlibrary
{
    public class Library
    {
        public List<Book> booksInLibrary = new List<Book>();

        public void AddBookToLibrary(string Title, int Count)
        {
            foreach (var item in booksInLibrary)
            {
                if (item.Title == Title)
                {
                    Count = Count + Count;
                }
            }

            var book = new Book(Title, Count);
            booksInLibrary.Add(book);
            Console.WriteLine($"Du har lagt till {book.Count} exemplar av boken {book.Title}.");
        }
        public void FindBook(string Title)
        {
            foreach (var item in booksInLibrary)
            {
                if (item.Title == Title)
                {
                    if (item.Count >= 1)
                    {
                        Console.WriteLine($"Du har lånat {item.Title}");
                        item.Count--;
                        Console.WriteLine($"Nu finns det totalt {item.Count} kvar att låna.");
                        item.Borrowed++;
                    }
                    else if (item.Count == 0)
                    {
                        Console.WriteLine("Alla exemplar är utlånade tyvärr!");
                    }
                }
                else
                {
                    Console.WriteLine("Det finns ingen bok med den titeln");
                }
            }
        }
        public void Return(string Title)
        {
            foreach (var item in booksInLibrary)
            {
                if (item.Title == Title)
                {
                    if (item.Borrowed <= 0)
                    {
                        Console.WriteLine("Det finns ingen bok utlånad.");
                    }
                    else
                    {
                        item.Count++;
                        item.Borrowed--;
                        Console.WriteLine($"Du har retunerat boken {item.Title}, Nu finns det totalt {item.Count} att låna.");
                    }

                }
                else
                {
                    Console.WriteLine("Du har inte lånat någon bok med den titeln.");
                }
            }
        }
    }
}