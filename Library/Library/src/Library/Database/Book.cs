using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.Database
{
    class Book : LibraryObject
    {
        private string Author;
        private int numpages;
        private int isbn;
        private string publisher;
        


        public Book(string Name, int numpages, int isbn, string publisher, int LibraryID) : base(Name, "Books", LibraryID)
        {
            
        }

        public void setAuthor(String author)
        {
            this.Author = author;
        }

        public String getAuthor()
        {
            return this.Author;
        }


        public void setNumPages(int numpages)
        {
            this.numpages = numpages;
        }

        public int getNumPages()
        {
            return this.numpages;
        }

        public void setISBN (int ISBN)
        {
            this.isbn = ISBN;
        }

        public int getISBN()
        {
            return this.isbn;
        }

        public void setPublisher(string Publisher)
        {
            this.publisher = Publisher;
        }

        public string getPublisher()
        {
            return this.publisher;
        }
    }
}
