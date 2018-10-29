using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.Database
{
    class CD : LibraryObject
    {
        
        private String Artist;


        public CD(String name, int LibraryID, String Artist) : base(name, "CD", LibraryID) {
            this.Artist = Artist;
        }
    }
}
