using System;
using AddBooks;

namespace DisplayBooks
{
    public class Display
    {
        public void Execute()
        {
            try
            {
                int booksCount = Add.bookList.Count;
                if (booksCount == 0)
                {
                    Console.WriteLine("No books added");
                    return;
                }
                for (int i = 0; i < booksCount; i++)
                {
                    Console.WriteLine($"Book Id: {Add.bookList[i].bookId}");
                    Console.WriteLine($"Title: {Add.bookList[i].title}");
                    Console.WriteLine($"Author: {Add.bookList[i].author}");
                    Console.WriteLine($"Price: {Add.bookList[i].price}");
                    Console.WriteLine("---------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
                
        }
    }
}
