using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Customer: User
    {
        
        public virtual List<Book> Books { get; set; }
        public virtual List<Book> WishList { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
