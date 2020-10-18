using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTvsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        static IBookRepository repository = new BookRepository();
        public string AddBook(Book book)
        {
            Book newBook = repository.AddNewBook(book);
            return "id =" + newBook.BookId;
           // throw new NotImplementedException();
        }

        public string DeleteBook(string id)
        {
            bool deleted = repository.DeleteBook( int.Parse(id));
            if(deleted)
            {
                return "Deleted";
            }
            else
            {
                return "Can not delete";
            }
        }

        public Book GetBookById(string id)
        {
            return repository.GetBookById(int.Parse(id));
            //throw new NotImplementedException();
        }

        public List<Book> GetBookList()
        {
            return repository.GetAllBook();
            //throw new NotImplementedException();
        }

        public string UpdateBook(Book book, string id)
        {
            bool updated = repository.UpdateBook(book);
            if(updated)
            {
                return "Updated";
            }
            else
            {
                return "Update fail";
            }
          
        }
    }
}
