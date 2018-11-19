using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.Database

{
    public abstract class LibraryObject
    {
        private String name;
        private String typeobj;
        private int LibraryID;

        public LibraryObject(String name, String typeobj, int LibraryID) {
            setObjectType(typeobj);
            setName(name);
            setLibraryID(LibraryID);
        }

        public string getObjectType()
        {
            return this.typeobj;
        } 
        public void setObjectType(String typeobj)
        {
            this.typeobj = typeobj;
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

        internal string GetObjectType()
        {
            throw new NotImplementedException();
        }
    }
}


