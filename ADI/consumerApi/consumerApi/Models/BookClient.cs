using consumerApi.BookServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consumerApi.Models
{
    public class BookClient
    {
        BookServiceClient client = new BookServiceClient();
        public List<Book> getAllBook()
        {
            var list = client.GetBookList().ToList();
            var rt = new List<Book>();
            list.ForEach(b => rt.Add(new Book()
            {
                BookId = b.BookId,
                ISBN = b.ISBN,
                Title = b.Title
                
            }));
               
            return rt;
        }
        public string storeBook(Book newBook)
        {
            var book = new BookServiceReference.Book() { 
                BookId = newBook.BookId,
                Title = newBook.Title,
                ISBN = newBook.ISBN
            };


            return client.AddBook(book);
        }
        public Book getBookById(int id)
        {
            var data = client.GetBookById(Convert.ToString(id));
            Book b = new Book();
            b.BookId = data.BookId;
            b.Title = data.Title;
            b.ISBN = data.ISBN;
            return b;

            
        }
        public string deleteBook(int id)
        {
          return client.DeleteBook(Convert.ToString(id));
           
        }
        public string editBook(Book newbook)
        {
            //var data = client.GetBookById(Convert.ToString(id));
            var book = new BookServiceReference.Book() {
                BookId = newbook.BookId,
                Title = newbook.Title,
                ISBN = newbook.ISBN
            };



            /*client.UpdateBook(book, Convert.ToString(id));*/


            return client.UpdateBook(book,Convert.ToString(newbook.BookId));
                }
    }
}