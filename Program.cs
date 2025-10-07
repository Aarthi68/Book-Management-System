using System;
using AddBooks;
using DisplayBooks;
using UpdateBooks;
using DeleteBooks;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select Operation: 1-Add, 2-Display, 3-Update, 4-Delete");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {

                case 1:
                    Add add = new Add();
                    add.Execute();
                    break;

                case 2:
                    Display display = new Display();
                    display.Execute();
                    break;

                case 3:
                    Update update = new Update();
                    update.Execute();
                    break;

                case 4:
                    Delete delete = new Delete();
                    delete.Execute();
                    break;

                default:
                    Console.WriteLine("Program ended");
                    return;
            }
            Console.WriteLine("---------------------------");
        }
    }
}
