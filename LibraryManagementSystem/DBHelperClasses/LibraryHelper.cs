using LibraryManagementSystem.HelperClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //this class helps to communicate with DB Book table 
    public static class LibraryHelper
    {
        static LibraryEntities context = new LibraryEntities();
        // retrieves all books from database
        public static List<Book> GetAllBooks()
        {
            List<Book> allBooks =
                (from b in context.Books
                 select b).ToList();
            
            return allBooks;
        }
        
        //returns all available books
        public static List<Book> GetAllUncheckedBooks()
        {            
            List<Book> allBooks = GetAllBooks();

            List<Book> uncheckedBooks = new List<Book>();

            foreach (Book book in allBooks)
            {
                if (book.CheckedOutBy == 0)
                    uncheckedBooks.Add(book);
            }

            return uncheckedBooks;
        }

        //returns all unavailable books
        public static List<Book> GetMemberBooks()
        {
            Member member = CurrentMember.GetCurrentMember();

            List<Book> allBooks = GetAllBooks();

            List<Book> memberBooks = new List<Book>();

            int memberID = Convert.ToInt32(member.MemberID);

            foreach (Book book in allBooks)
            {
                if (book.CheckedOutBy == memberID) 
                    memberBooks.Add(book);
            }

            return memberBooks;
        }

        //returns the book with selected ISBN
         public static List<Book> GetSelectedBooks(List<string> isbns)
        {
            List<Book> selectedBooks = new List<Book>();

            foreach (string isbn in isbns)
            {
                Book dbBook = context.Books.Find(isbn);
                selectedBooks.Add(dbBook);
            }

            return selectedBooks;
        }

        //by checking-in the selected book we set CheckedOutBy = 0
        public static bool CheckInBooks(List<Book> books)
        {
            
            Member member = CurrentMember.GetCurrentMember();

            foreach (Book book in books)
            {
                Book dbBook = context.Books.Find(book.ISBN);
                dbBook.CheckedOutBy = 0;
            }

            context.SaveChanges();

            if (IsChecked(books))
                return false;
            else
                return true;
        }

        //by checking-out the selected book we set CheckedOutBy = memberID
        public static bool CheckoutBooks(List<Book> books)
        {
            
            Member member = CurrentMember.GetCurrentMember();

            int memberID = Convert.ToInt32(member.MemberID);

            foreach (Book book in books)
            {
                Book dbBook = context.Books.Find(book.ISBN);
                dbBook.CheckedOutBy = memberID;
            }

            context.SaveChanges();

            if (IsChecked(books))
                return true;
            else
                return false;
        }

        //returns True if the book is available
        private static bool IsChecked(List<Book> books)
        {

            foreach (Book b in books)
            {
                Book dbBook = context.Books.Find(b.ISBN);

                if (dbBook.CheckedOutBy == 0)
                    return false;
            }

            return true;
        }

        //returns true if such title already exists
        public static bool IsBook(Book book)
        {
            List<Book> allBooks = GetAllBooks();

            foreach (Book b in allBooks)
            {
                if (book.Title == b.Title)
                    return true;
            }

            return false;
        }

        //returns true if such ISBN already exists
        public static bool IsBook(string isbn)
        {

            Book isBook = context.Books.Find(isbn);

            if (isBook is null)
                return false;
            else
                return true;
        }

        //adding a new book to database
        public static void AddBook(Book book)
        {

            context.Books.Add(book);

            context.SaveChanges();
        }

        //removing a book from the database
        public static void RemoveBook(string isbn)
        {

            Book book = context.Books.Find(isbn);
            
            context.Books.Remove(book);

            context.SaveChanges();
        }
    }
}
