using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(20)]
        [Required]
        public String FirstName { get; set; }
        [MaxLength(20)]
        [Required]
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual List<BookAuthor> BooksAuthored { get; set; }
    }
}
