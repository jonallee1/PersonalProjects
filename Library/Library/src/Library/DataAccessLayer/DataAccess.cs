using System;
using System.Collections.Generic;
using System.Text;
using Library.src.Library.Database;

namespace Library.src.Library.DataAccessLayer
{
    class DataAccess
    {
        private DB db;

        DataAccess()
        {
            db = new DB();
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


    }
}
