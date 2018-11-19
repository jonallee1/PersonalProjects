using Library.src.Library.DataAccessLayer;
using Library.src.Library.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.ServiceLayer
{
    
    class LibraryService
    {
        private DataAccess DA;
        int member;
        bool signedIn;

        public LibraryService()
        {
            this.DA = new DataAccess();
            signedIn = false;
        }

        public void addLibraryObject()
        {
           
        }

        public List<LibraryObject> returnSearch(String Keyword)
        {
            return DA.returnSearch(Keyword);
        }

        public void setUser(int memberID)
        {
            this.member = memberID;
        }

        public bool checkCredentials(int memberID, string Password)
        {
            if (!DA.MemberExists(memberID))
            {
                Console.WriteLine("member doesn't exist");
                return false;
            }
            else
            {
                if (DA.getPassword(memberID) != Password)
                {
                    Console.WriteLine("incorrect password: " + DA.getPassword(memberID));
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool checkSignedIn()
        {
            if (signedIn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void signIn(int MemberID)
        {
            this.member = MemberID;
            signedIn = true;
        }

        public void signOut()
        {
            this.member = -1;
            signedIn = false;
        }

        public int createUser(String name, DateTime birthday, String username, String password)
        {
            return DA.createUser(name, birthday, username, password);
        }

        public void checkOut(int libraryID)
        {
            DA.checkOut(member, libraryID);
        }

        public List<LibraryObject> checkOutItems()
        {
            return DA.checkOutItems(member);
        }

        public void returnBook(int libraryID)
        {
            DA.returnBook(libraryID, member);
        }
    }
}
 