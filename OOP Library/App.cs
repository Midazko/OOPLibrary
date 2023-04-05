using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOPlibrary;

namespace OOPlibrary
{
    public class App
    {
        public void Run()
        {
            var library = new Library();
            var sel = "";

            while (sel != "4")
            {
                Console.Clear();
                Meny();
                sel = Console.ReadLine();
                switch (sel)
                {
                    case "1":
                        AddBook(library);
                        break;
                    case "2":
                        BorrowBook(library);
                        break;
                    case "3":
                        ReturnBook(library);
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            }

        }
        public void Meny()
        {
            Console.WriteLine("Välkommen Till Biblioteket\n");
            Console.WriteLine("1. Lägg till en bok i Biblioteket\n" +
                              "2. Låna en bok\n" +
                              "3. Returnera en bok\n" +
                              "4. Avsluta Programmet");
        }
        public void AddBook(Library library)
        {
            Console.Write("Titel: ");
            var Title = Console.ReadLine();
            Console.Write("Hur många exemplar: ");
            var Count = Convert.ToInt32(Console.ReadLine());
            library.AddBookToLibrary(Title, Count);
            MenyReturn();

        }
        public void BorrowBook(Library library)
        {
            Console.Write("Titel: ");
            var Title = Console.ReadLine();
            library.FindBook(Title);
            MenyReturn();
        }

        public void ReturnBook(Library library)
        {
            Console.Write("Titel: ");
            var Title = Console.ReadLine();
            library.Return(Title);
            MenyReturn();
        }
        public void MenyReturn()
        {
            Console.WriteLine("\nEnter för att gå tillbaka till menyn");
            Console.ReadKey();
        }
    }
}