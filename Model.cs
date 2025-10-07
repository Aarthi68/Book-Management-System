using System; 
public class Book   // model class
{
    public int bookId;
    public string title;
    public string author;
    public double price;

    public Book(int bookId, string title, string author, double price)
    {
        this.bookId = bookId;
        this.title = title;
        this.author = author;
        this.price = price;
    }
}
