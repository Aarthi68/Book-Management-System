using System;
using AddBooks;

namespace DeleteBooks
{
    class Delete
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Enter the Book Id to Delete");
                int bId = Convert.ToInt32(Console.ReadLine());
                int count = Add.bookList.Count;
                bool found = false;
                for (int i = 0; i < count; i++)
                {
                    int id = Add.bookList[i].bookId;
                    if (id == bId)
                    {
                        Add.bookList.RemoveAt(i);
                        Console.WriteLine("Book deleted successfully!");
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