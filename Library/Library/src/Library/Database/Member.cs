using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.Database
{
    class Member
    {
        private String name;
        private DateTime birthday;
        private int memberID;
        private String username;
        private String password;
        private Dictionary<int, LibraryObject> checkedOut;

        public Member(String name, DateTime birthday, int memberID, String username, String password)
        {
            setName(name);
            setBirthday(birthday);
            setMemberID(memberID);
            setPassword(password);
            setUsername(username);
            checkedOut = new Dictionary<int, LibraryObject>();
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }



        public void setMemberID(int memberID)
        {
            this.memberID = memberID;
        }

        public int getMemberID()
        {
            return this.memberID;
        }



        public void setBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public DateTime getBirthday()
        {
            return this.birthday;
        }



        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getPassword()
        {
            return this.password;
        }



        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getUsername()
        {
            return this.username;
        }
        public void rentBook(LibraryObject rentedObject)
        {
            checkedOut.Add(rentedObject.getLibraryID(), rentedObject);
        }

        public void returnBook(int libraryID)
        {
            checkedOut.Remove(libraryID);
        }

        public List<LibraryObject> checkedOutItems()
        {
            List<LibraryObject> output = new List<LibraryObject>();
            foreach (KeyValuePair<int, LibraryObject> kvp in checkedOut)
            {
                output.Add(kvp.Value);
            }
            return output;
        }
    }
}
