using System;
using System.Collections.Generic;

namespace Athena.Core
{
    public class User
    {
        public Int32 Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String Zipcode { get; set; }
        public IList<Book> Library { get; set; }
        public IList<Book> Watchlist { get; set; }

        public User()
        {
            Library = new List<Book>();
            Watchlist = new List<Book>();
        }
    }
}