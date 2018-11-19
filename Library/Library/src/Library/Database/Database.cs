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
            initialLibraryCollection();
                


        }

        public void AddBook(string Name, int numpages, int isbn, string publisher)
        {
            LibraryObject newBook = new Book( Name, numpages,  isbn,  publisher, currentNumCollectionID);
            Collection.Add(currentNumCollectionID, newBook);
            currentNumCollectionID = currentNumCollectionID + 1;
        }

        public void rentedObject(int memberID,int libraryID)
        {
            Members[memberID].rentBook(Collection[libraryID]);
        }

        

        public void AddCD(String name,  String Artist)
        {
            LibraryObject newCD = new CD( name, currentNumCollectionID, Artist);
            Collection.Add(currentNumCollectionID, newCD);
            currentNumCollectionID = currentNumCollectionID + 1;
        }


        public void AddDVD(String Name,  String Director, int length)
        {
            LibraryObject newDVD = new DVD( Name,  currentNumCollectionID,  Director,  length);
            Collection.Add(currentNumCollectionID, newDVD);
            currentNumCollectionID = currentNumCollectionID + 1;
        }

        public void AddNewspaper(String Name)
        {
            LibraryObject newNewspaper = new Newspaper( Name, currentNumCollectionID);
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

        public List<LibraryObject> checkOutItems(int memberID)
        {
            return Members[memberID].checkedOutItems();
        }

        public List<LibraryObject> returnSearch(String Keyword)
        {
            List<LibraryObject> output = new List<LibraryObject>();
            if (Keyword == "")
            {
                
                foreach (KeyValuePair<int, LibraryObject> KVP in Collection)
                {
                   
                    output.Add(KVP.Value);
                    
                }
            }
            else
            {
                foreach (KeyValuePair<int, LibraryObject> KVP in Collection)
                {
                    if (KVP.Value.getName().Contains(Keyword))
                    {
                        output.Add(KVP.Value);
                    }
                }
            }
            
            return output;
        }

        public void returnBook(int libraryID, int memberID)
        {
            Members[memberID].returnBook(libraryID);
        }


        public int AddMember(String name, DateTime birthday,  String username, String password)
        {
           
         
            currentNumMembersID = currentNumMembersID + 1;
            Member newMember = new Member(name, birthday, currentNumMembersID, username, password);
            Members.Add(currentNumMembersID, newMember);
            return currentNumMembersID;
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

        public void initialLibraryCollection()
        {
            AddBook("Book 1", 123, 345342452, "a pub");
            AddBook("Book 2", 145, 234523452, "b pub");
            AddBook("Book 3", 123, 432542234, "c pub");
            AddBook("Book 4", 345, 785675545, "d pub");
            AddMember("asdf", new DateTime(1190, 12, 12), "asdf", "asdf");


        }
    }
}
