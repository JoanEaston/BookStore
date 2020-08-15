using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class AdminUser: User
    {
              
        public virtual AdminType Admintype { get; set; }
    }
}
