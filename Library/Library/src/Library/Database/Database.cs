using Library.src.Library.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.Database
{
    class DB
    {

        private Dictionary<int, LibraryObject> Collection = new Dictionary<int, LibraryObject>();
        private Dictionary<int, Member> Members = new Dictionary<int, Member>();
        int currentNumCollectionID;
        int currentNumMembersID;

        public DB()
        {
            this.currentNumCollectionID = 000000000000000000;
            this.currentNumMembersID = 00000000000000000;
        }

        public void AddBook(string Name, int numpages, int isbn, string publisher, int LibraryID)
        {
            LibraryObject newBook = new Book( Name, numpages,  isbn,  publisher, LibraryID);
            Collection.Add(currentNumCollectionID, newBook);
            currentNumCollectionID = currentNumCollectionID + 1;
        }



        public void AddCD(String name, int LibraryID, String Artist)
        {
            LibraryObject newCD = new CD( name, LibraryID, Artist);
            Collection.Add(currentNumCollectionID, newCD);
            currentNumCollectionID = currentNumCollectionID + 1;
        }


        public void AddDVD(String Name, int LibraryID, String Director, int length)
        {
            LibraryObject newDVD = new DVD( Name,  LibraryID,  Director,  length);
            Collection.Add(currentNumCollectionID, newDVD);
            currentNumCollectionID = currentNumCollectionID + 1;
        }

        public void AddNewspaper(String Name, int LibraryID)
        {
            LibraryObject newNewspaper = new Newspaper( Name, LibraryID);
            Collection.Add(currentNumCollectionID, newNewspaper);
            currentNumCollectionID = currentNumCollectionID + 1;
        }

        public LibraryObject GetLibraryObject(int LibraryID)
        {
            return Collection[LibraryID];
        }

        public bool validLibraryID(int LibraryID)
        {
            if (Collection.ContainsKey(LibraryID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveLibraryObject(int LibraryID)
        {
            Collection.Remove(LibraryID);
        }






        public void AddMember(String name, DateTime birthday, int memberID, String username, String password)
        {
            Member newMember = new Member( name,  birthday, memberID,  username, password);
            Members.Add(currentNumMembersID, newMember);
            currentNumMembersID = currentNumMembersID + 1;
        }
        public void RemoveMember(int MemberID)
        {
            Members.Remove(MemberID);
        }
        public Member GetMember(int MemberID)
        {
            return Members[MemberID];
        }

        public bool ValidMemberID(int MemberID)
        {
            if (Members.ContainsKey(MemberID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
