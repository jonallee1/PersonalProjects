using System;
using System.Collections.Generic;
using System.Text;
using Library.src.Library.Database;

namespace Library.src.Library.DataAccessLayer
{
    class DataAccess
    {
        private DB db;

        public DataAccess()
        {
            this.db = new DB();
        }

        public bool LibraryObjectExists(int LibraryObjectID)
        {
            if (db.validLibraryID(LibraryObjectID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MemberExists(int memberID)
        {
            if (db.ValidMemberID(memberID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<LibraryObject> returnSearch(String Keyword)
        {
            
            return db.returnSearch(Keyword);
        }


        public string getPassword(int memberID)
        {
            return db.GetMember(memberID).getPassword();
        }

        public int createUser(String name, DateTime birthday, String username, String password)
        {
            return db.AddMember(name, birthday, username, password);
        }

        public void checkOut(int memberID, int libraryID)
        {
            db.rentedObject(memberID, libraryID);
        }

        public List<LibraryObject> checkOutItems(int memberID)
        {
            return db.checkOutItems(memberID);
        }

        public void returnBook(int libraryID, int memberID)
        {
            db.returnBook(libraryID, memberID);
        }

    }
}
