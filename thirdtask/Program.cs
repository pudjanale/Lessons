using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public string GetInfo()
        {
            return $"Title: {Title}, Author: {Author}, Pages: {Pages}";
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine(book.GetInfo());
            }
        }

        public Book FindBook(string title)
        {
            return books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("Social Engineering: The Science of Human Hacking", "Christopher Hadnagy", 320); 
            Book book2 = new Book("Older Brother Is Watching You: How to Protect Yourself in the Digital World", "Mikhail Raitman", 694); 
            Book book3 = new Book("The Green Mile", "Stephen King", 368);  


            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("Available books:");
            library.ShowBooks();

            Console.WriteLine("\nSearching for 'The Green Mile':");
            Book foundBook = library.FindBook("The Green Mile");
            if (foundBook != null)
            {
                Console.WriteLine(foundBook.GetInfo());
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

            Console.ReadKey();  
        }
    }
}