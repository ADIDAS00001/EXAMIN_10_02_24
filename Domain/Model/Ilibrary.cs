namespace Domain.Model;

public interface Ilibrary 
{
    public void AddBook(Book books);
    public void UpdateBook(int id);
    public void DeleteBook(int id);
    public List<Book> SearchByTitle(string title);
    public List<Book> SearchByAuthor(string author);
}
