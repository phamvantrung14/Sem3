using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTvsWCF
{
    //co the truy cap dc 
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ISBN { get; set; }
    }
    public interface IBookRepository
    {
        List<Book> GetAllBook();
        Book GetBookById(int id);
        Book AddNewBook(Book item);
        bool DeleteBook(int id);
        bool UpdateBook(Book item);
    }
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();
        private int counter = 1;
        public BookRepository()
        {
            AddNewBook(new Book() { Title = "C# programing", ISBN = "123456789" });
            AddNewBook(new Book() { Title = "Java programing", ISBN = "123456789" });
            AddNewBook(new Book() { Title = "PHP programing", ISBN = "123456789" });
            AddNewBook(new Book() { Title = "Python programing", ISBN = "123456789" });
            AddNewBook(new Book() { Title = "Scala programing", ISBN = "123456789" });
        }

        public Book AddNewBook(Book item)
        {
            if(item == null)
            {
                throw new ArgumentException("No agrument");
            }
            item.BookId = counter++;
            books.Add(item);
            return item;

            
            //throw new NotImplementedException();
        }

        public bool DeleteBook(int id)
        {
            int idx = books.FindIndex(b => b.BookId == id);
            if(idx==-1)
            {
                return false;
            }
            books.RemoveAll(b => b.BookId == id);
            return true;
            //throw new NotImplementedException();
        }

        public List<Book> GetAllBook()
        {
            return books;
            //throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            return books.Find(b => b.BookId == id);
            //throw new NotImplementedException();
        }

        public bool UpdateBook(Book bookUpdate)
        {
            if(bookUpdate == null)
            {
                throw new ArgumentNullException("Not update book");
            }
            int idx = books.FindIndex(b => b.BookId == bookUpdate.BookId);
            if(idx==-1)
            {
                return false;
            }
            books.RemoveAt(idx);
            books.Add(bookUpdate);
            return true;
            
        }
    }
}