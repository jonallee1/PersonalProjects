using System;
using System.Collections.Generic;
using System.Text;
using Library.src.Library.ServiceLayer;
using Library.src.Library.Database;

namespace Library.src.Library.ControllerLayer
{
    

    class Controller
    {
        private LibraryService Lib;
        public Controller()
        {
            this.Lib = new LibraryService();
        }

        public void addLibraryObject()
        {

        }

        public List<LibraryObject> returnSearch(String Keyword)
        {
            return Lib.returnSearch(Keyword);


        }
        //encrypt password when reading in
        public void signIn(int memberID)
        {
            Lib.signIn(memberID);
        }

        public void signOut()
        {
            Lib.signOut();
        }

        public bool checkCredentials(int memberID, string Password)
        {
            if(Lib.checkCredentials(memberID, Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int createUser(String name, DateTime birthday, String username, String password)
        {
            return Lib.createUser(name, birthday, username, password);
        }

        public void checkOut(int libraryID)
        {
            Lib.checkOut(libraryID);
        }

        public List<LibraryObject> checkOutItems()
        {
            return Lib.checkOutItems();
        }

        public void returnBook(int libraryID)
        {
            Lib.returnBook(libraryID);
        }
    }
}
