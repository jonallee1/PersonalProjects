using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.Database

{
    public abstract class LibraryObject
    {
        private String name;
        private String type;
        private int LibraryID;

        public LibraryObject(String name, String Type, int LibraryID) {
            setObjectType(Type);
            setName(name);
            setLibraryID(LibraryID);
        }

        public string getObjectType()
        {
            return this.type;
        } 
        public void setObjectType(String Type)
        {
            this.type = Type;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setLibraryID(int LibraryID)
        {
            this.LibraryID = LibraryID;
        }

        public int getLibraryID()
        {
            return this.LibraryID;
        }
    }
}


