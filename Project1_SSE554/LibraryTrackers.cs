using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_SSE554
{
    public partial class LibraryTrackers : Form
    {
        public LibraryTrackers()
        {
            InitializeComponent();
        }
    }

    public interface BookRental
    {
        void picked(Observer o);
        void dropped(Observer o);
        List<string> notifyLibrarian();
    }

    public interface Observer
    {
        void statusOfBook(string bookName, string status, double date);

    }

    public class Librarian : BookRental
    {
        public List<Observer> booksRented;
        private string bookName;
        private double date;
        private string status;

        public Librarian()
        {
            booksRented = new List<Observer>();
        }

        public void dropped(Observer newO)
        {
            booksRented.Remove(newO);
        }

        public List<string> notifyLibrarian()
        {
            List<string> allStuses = new List<string>();
            foreach (var x in booksRented)
            {
                allStuses.Add(bookName + " was " + status);
            }
            return allStuses;
        }

        public void picked(Observer newO)
        {
            booksRented.Add(newO);
        }

        public void setBookName(string newBookName)
        {
            this.bookName = newBookName;
        }

        public void setDate(double newDate)
        {
            this.date = newDate;
        }

        public List<string> setStatus(string newStatus)
        {
            this.status = newStatus;
            return notifyLibrarian();
        }
    }

    public class LibrarianObserver : Observer
    {
        public List<Observer> booksRented;
        private string bookName;
        private double date;
        private string status;

        private static int bookIdTracker = 0;

        private int bookId;

        private BookRental book;

        public LibrarianObserver(BookRental book)
        {
            this.book = book;
            Random rnd1 = new Random();
            bookIdTracker = rnd1.Next(1, 1000);
            this.bookId = bookIdTracker;

            book.picked(this);
        }

        void Observer.statusOfBook(string bookName, string status, double date)
        {
            this.bookName = bookName;
            this.date = date;
            this.status = status;
        }
    }
}
