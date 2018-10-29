using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.Database
{
    class DVD : LibraryObject
    {
        private String Director;
        private int length;


        public DVD(String Name, int LibraryID, String Director, int length) : base(Name, "DVD", LibraryID)
        {
            this.Director = Director;
            this.length = length;
        }

    }
}
