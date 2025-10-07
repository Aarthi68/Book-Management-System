using System; 
using System.Collections.Generic;

namespace AddBooks
{
    public class Add   // operation class
    {
        public static List<Book> bookList = new List<Book>();
        public void Execute()
        {
            try
            {
                Console.WriteLine("Enter Book Id:");
                int bookId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Book Title:");
                string title = Console.ReadLine()!;

                Console.WriteLine("Enter Author:");
                string author = Console.ReadLine()!;

                Console.WriteLine("Enter Price:");
                double price = Convert.ToDouble(Console.ReadLine());

                Book book = new Book(bookId, title, author, price);
                bookList.Add(book);

                Console.WriteLine("Book added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
