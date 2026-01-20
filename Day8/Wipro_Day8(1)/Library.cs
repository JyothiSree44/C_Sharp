using System.Collections.Generic;
using System.Linq;

namespace Wipro_Day8_1
{
    public class Library
    {
        public List<Book> Books { get; } = new List<Book>();
        public List<Borrower> Borrowers { get; } = new List<Borrower>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string cardNumber)
        {
            Book book = Books.First(b => b.ISBN == isbn);
            Borrower borrower = Borrowers.First(br => br.LibraryCardNumber == cardNumber);

            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string cardNumber)
        {
            Book book = Books.First(b => b.ISBN == isbn);
            Borrower borrower = Borrowers.First(br => br.LibraryCardNumber == cardNumber);

            borrower.ReturnBook(book);
        }
    }
}
