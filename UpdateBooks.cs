using System;
using AddBooks;

namespace UpdateBooks
{
    class Update
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Enter the Book Id to Update");
                int bId = Convert.ToInt32(Console.ReadLine());
                int count = Add.bookList.Count;
                bool found = false;
                for (int i = 0; i < count; i++)
                {
                    int id = Add.bookList[i].bookId;
                    if (id == bId)
                    {
                        Console.WriteLine("Enter new Title:");
                        Add.bookList[i].title = Console.ReadLine()!;

                        Console.WriteLine("Enter new Author:");
                        Add.bookList[i].author = Console.ReadLine()!;

                        Console.WriteLine("Enter new Price:");
                        Add.bookList[i].price = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Book updated successfully!");
                        found = true;
                        break;

                    }

                }
                if (!found)
                {
                    Console.WriteLine("Book is not Available");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: "+ex);
            }
        }
    }
}