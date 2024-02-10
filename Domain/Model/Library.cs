

namespace Domain.Model;

public class Library : Ilibrary
{
     List<Book> _book =new List<Book>();
    public void AddBook(Book books)
    {
        _book.Add(books);
    }
    public void DeleteBook(int id)
    {
       var delete= _book.FirstOrDefault(p=>p.Id==id);
        _book.Remove(delete);
    }
    public Book SearchByAuthor(string author)
    {
        var auth = _book.FirstOrDefault(p=>p.Author==author);
        return auth;
    }
    public Book SearchByTitle(string title)
    {
        var tit = _book.FirstOrDefault(p=>p.Title==title);
        return tit;    
    }
  
}
